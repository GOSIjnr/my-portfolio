using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using MyPortfolio;
using MyPortfolio.Models.App;
using MyPortfolio.Services.Profile;
using MyPortfolio.Services.StateManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<SelectedServiceState>();
builder.Services.AddScoped<ScrollLockService>();

builder.Services.AddSingleton(new AppContent
{
	User = new GosiJnrProfileData(),
	Layout = new PortfolioLayoutData()
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
