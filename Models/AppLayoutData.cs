using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public static class AppLayoutData
{
	public static NavBrandData NavigationBrandData { get; set; } = new(
		"Images/icon.svg",
		"GOSIjnr",
		"Logo"
	);

	public static NavLinkItemData[] NavigationLinkItems { get; set; } =
	[
		new("About Me", "aboutme", "nav-text"),
		new("Skills", "skills", "nav-text"),
		new("Projects", "projects", "nav-text"),
		new("Resume", "resume", "nav-text"),
	];

	public static NavLinkItemData ContactNavigationLink { get; set; } = new(
		"Let's Connect",
		"contact",
		"nav-button"
	);

	public static NavLinkItemData ContactNavigationLinkAccent { get; set; } = new(
		"Let's Connect",
		"contact",
		"nav-button-accent"
	);

	public static HomeData HomePageData { get; set; } = new(
		"Code. Design. Deploy. ",
		"Play.",
		"I turn caffeine into code, pixels into purpose, and bugs into... features (sometimes).",
		"Images/backdrop.jpg"
	);

	public static NavLinkItemData CheckProjectsNavigationLink { get; set; } = new(
		"Check My Works",
		"projects",
		"nav-button"
	);
}
