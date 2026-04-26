using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio;
using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.Data;
using MyPortfolio.Services.Browser;
using MyPortfolio.Services.ContactForm;
using MyPortfolio.Services.Loader;
using MyPortfolio.Services.StateManagement;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// ---------- Root Components ----------
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// ---------- Core Services ----------
builder.Services.AddScoped(sp => new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<YamlLoaderService>();

// ---------- UI & State Services ----------
builder.Services.AddScoped<SelectedServiceState>();
builder.Services.AddScoped<ScrollLockService>();
builder.Services.AddScoped<FileAndTabService>();
builder.Services.AddScoped<ImageLoaderService>();
builder.Services.AddScoped(typeof(ResizeEventListenerService<>));

// ---------- Form & Email Services ----------
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IContactFormDataService, ContactFormDataService>();
builder.Services.AddScoped<CooldownService>();
builder.Services.AddScoped<EmailSubmitHandler>();

// ---------- Configurations ----------
builder.Services.Configure<EmailSubmitSettings>(options =>
{
	options.IsEnabled = true;
});

// ---------- Load YAML Configuration Before App Starts ----------
using ServiceProvider? tempProvider = builder.Services.BuildServiceProvider();
var loader = tempProvider.GetRequiredService<YamlLoaderService>();

var userProfile = await loader.LoadYamlAsync<UserProfileData>("data/profile.yaml")
	?? throw new InvalidOperationException("Failed to load or validate profile data.");

var layout = await loader.LoadYamlAsync<AppLayoutData>("data/layout.yaml")
	?? throw new InvalidOperationException("Failed to load or validate layout data.");

// ---------- Register Loaded Data as Singleton ----------
builder.Services.AddSingleton(new PortfolioData
{
	User = userProfile,
	Layout = layout
});

// ---------- Run Application ----------
await builder.Build().RunAsync();
