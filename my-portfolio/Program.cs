using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio;
using MyPortfolio.Models.Data;
using MyPortfolio.Services.Loader;
using MyPortfolio.Services.StateManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient scoped for YAML/web access
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Services
builder.Services.AddScoped<SelectedServiceState>();
builder.Services.AddScoped<ScrollLockService>();
builder.Services.AddSingleton<YamlLoaderService>();

// Build temporary provider to load YAMLs at startup
using var tempProvider = builder.Services.BuildServiceProvider();
var loader = tempProvider.GetRequiredService<YamlLoaderService>();

var userProfile = await loader.LoadYamlAsync<UserProfileData>("data/default-profile.yaml") ?? throw new InvalidOperationException("❌ Failed to load or validate 'default-profile.yaml'.");

var layout = await loader.LoadYamlAsync<AppLayoutData>("data/layout.yaml") ?? throw new InvalidOperationException("❌ Failed to load or validate 'layout.yaml'.");

// Register strongly typed config
builder.Services.AddSingleton(new PortfolioData
{
	User = userProfile,
	Layout = layout
});

// Start Blazor app
await builder.Build().RunAsync();
