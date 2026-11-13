using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1. Protección: Si Azure no tiene las variables JWT, usamos unas de respaldo
var jwtSettings = builder.Configuration.GetSection("Jwt");
var secretKey = jwtSettings.GetValue<string>("Key") ?? "SuperClaveSecretaDeRespaldoParaQueNoFalle123!";
var validIssuer = jwtSettings.GetValue<string>("Issuer") ?? "ApiLibrum";
var validAudience = jwtSettings.GetValue<string>("Audience") ?? "ApiLibrum";

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
        ValidateIssuer = true,
        ValidIssuer = validIssuer,
        ValidateAudience = true,
        ValidAudience = validAudience,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

// 2. Conexión fija temporal para prueba de fuego
var connectionString = "Server=tcp:librumdbserver.database.windows.net,1433;Initial Catalog=LibrumDB;Persist Security Info=False;User ID=CloudSA3c02abec;Password=Biblium2026*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

builder.Services.AddDbContext<DataContext>(opciones =>
    opciones.UseSqlServer(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirBlazor", app =>
    {
        app.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseDeveloperExceptionPage();

// 3. Bloque seguro para aplicar migraciones sin bloquear el arranque si hay un fallo temporal
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<DataContext>();
        if (dbContext.Database.IsRelational())
        {
            dbContext.Database.Migrate();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Ocurrió un error al aplicar las migraciones en la base de datos.");
    }
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("PermitirBlazor");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();