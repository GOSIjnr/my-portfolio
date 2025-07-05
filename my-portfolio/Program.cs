using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio;
using MyPortfolio.Models.Data;
using MyPortfolio.Services.Loader;
using MyPortfolio.Services.StateManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register root components for the Blazor app
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure logging level based on build configuration
#if DEBUG
builder.Logging.SetMinimumLevel(LogLevel.Debug);
#else
builder.Logging.SetMinimumLevel(LogLevel.Error);
#endif

// Register HttpClient for making HTTP requests (e.g., loading YAML files)
builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

// Register application services
builder.Services.AddScoped<SelectedServiceState>();    // Manages selected service state
builder.Services.AddScoped<ScrollLockService>();        // Handles scroll lock logic
builder.Services.AddSingleton<YamlLoaderService>();     // Loads and parses YAML files

// Build a temporary service provider to load configuration data at startup
using var tempProvider = builder.Services.BuildServiceProvider();
var loader = tempProvider.GetRequiredService<YamlLoaderService>();

// Load and validate user profile data from YAML
var userProfile = await loader.LoadYamlAsync<UserProfileData>("data/default-profile.yaml")
	?? throw new InvalidOperationException("Failed to load or validate profile data.");

var layout = await loader.LoadYamlAsync<AppLayoutData>("data/layout.yaml")
	?? throw new InvalidOperationException("Failed to load or validate layout data.");

// Register strongly-typed configuration as a singleton for DI
builder.Services.AddSingleton(new PortfolioData
{
	User = userProfile,
	Layout = layout
});

// Build and run the Blazor WebAssembly application
await builder.Build().RunAsync();
