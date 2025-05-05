using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public class MainLayoutData
{
	public NavBrandData BrandInfo { get; private set; } = new("Images/icon.svg", "GOSIjnr", "Logo");

	public NavLinkItemData[] NavLinkItems { get; private set; } = [
		new("About Me", "#home", "nav-text" ),
		new("Skills", "#counter", "nav-text" ),
		new("Projects", "#weather", "nav-text" ),
		new("Resume", "#myportfolio", "nav-text" ),
	];

	public NavLinkItemData ContactData { get; private set; } = new("Let's Connect", "#contact", "nav-button");
}
