using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using RealEstate.Client;
using RealEstate.Client.Services.Building;
using RealEstate.Client.Services.HttpClients;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IBuildingService, BuildingService>();
builder.Services.AddTransient<IHttpClientService, HttpClientService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
