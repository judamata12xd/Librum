using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Vista;
using Vista.Servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var urlLocal = "https://localhost:7141";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlLocal) });

builder.Services.AddScoped<IRepositorio, Repositorio>();

await builder.Build().RunAsync();

