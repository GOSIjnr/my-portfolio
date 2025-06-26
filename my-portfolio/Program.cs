using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio.Models.Data;
using MyPortfolio.Services.Loader;
using MyPortfolio.Services.StateManagement;
using MyPortfolio.Contracts.Validation;
using MyPortfolio.Services.Validation;
using MyPortfolio.Contracts.Layout;
using MyPortfolio.Contracts.Profile;
using MyPortfolio;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient should be added early because YamlLoaderService depends on it
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register app services
builder.Services.AddScoped<SelectedServiceState>();
builder.Services.AddScoped<ScrollLockService>();
builder.Services.AddSingleton<YamlLoaderService>();

// Register validators (optional)
builder.Services.AddScoped<IValidator<IUserProfileData>, UserProfileValidator>();
builder.Services.AddScoped<IValidator<IAppLayoutData>, LayoutDataValidator>();
builder.Services.AddScoped<IValidator<PortfolioData>, PortfolioDataValidator>();

// Temporary build ServiceProvider to load YAML BEFORE app runs
using var tempProvider = builder.Services.BuildServiceProvider();
var loader = tempProvider.GetRequiredService<YamlLoaderService>();

var userProfile = await loader.LoadYamlAsync<UserProfileData>("data/default-profile.yaml");
var layout = await loader.LoadYamlAsync<AppLayoutData>("data/layout.yaml");

// Add strongly-typed PortfolioData as singleton so it can be injected anywhere
builder.Services.AddSingleton(new PortfolioData
{
	User = userProfile,
	Layout = layout
});

await builder.Build().RunAsync();
