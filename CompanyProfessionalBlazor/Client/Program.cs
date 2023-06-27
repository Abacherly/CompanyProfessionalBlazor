global using CompanyProfessionalBlazor.Client;
global using CompanyProfessionalBlazor.Client.Services.CompanyProfessionalService;
global using CompanyProfessionalBlazor.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICompanyProfessionalService, CompanyProfessionalService>();

await builder.Build().RunAsync();
