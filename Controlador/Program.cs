using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opciones =>
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));

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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors("PermitirBlazor");

app.UseAuthorization();
app.MapControllers();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());
app.Run();

