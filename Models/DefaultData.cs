using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public static class DefaultData
{
	public static NavBrandData NavigationBrandInformation { get; private set; } = new("Images/icon.svg", "My Portfolio", "Portfolio Logo");

	public static NavLinkItemData[] MainNavigationLinks { get; private set; } =
	[
		new("Home", "#home", "nav-text"),
		new("About", "#about", "nav-text"),
		new("Skills", "#skills", "nav-text"),
		new("Projects", "#projects", "nav-text"),
		new("Blog", "#blog", "nav-text"),
		new("Resume", "#resume", "nav-text"),
	];

	public static NavLinkItemData ContactNavigationItem { get; private set; } = new("Contact Me", "#contact", "nav-button");
}
