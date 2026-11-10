using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization; 
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Vista;
using Vista.Providers;
using Vista.Servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var urlLocal = "https://localhost:7141";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlLocal) });

builder.Services.AddScoped<IRepositorio, Repositorio>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

await builder.Build().RunAsync();

