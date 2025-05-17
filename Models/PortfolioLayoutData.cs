using MyPortfolio.Contracts;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public class PortfolioLayoutData : IAppLayoutData
{
	private static readonly List<NavigationItem> _navigationLinks =
	[
		new("About Me", "aboutme", ""),
		new("Skills", "skills", ""),
		new("Projects", "projects", ""),
		new("Resume", "resume", ""),
	];

	private static readonly NavigationItem _contactNavigationLink = new("Let's Connect", "contact", "button");
	private static readonly NavigationItem _contactNavigationLinkAccent = new("Let's Connect", "contact", "button-accent");
	private static readonly NavigationItem _projectsNavigationLink = new("Check My Works", "projects", "button");

	private static readonly HomePageContentInfo _homePageContentInfo = new(
		"Code. Design. Deploy. ",
		"Play.",
		"I turn caffeine into code, pixels into purpose, and bugs into... features (sometimes).",
		"images/backdrop.jpg"
	);

	public List<NavigationItem> NavigationLinks => _navigationLinks;
	public NavigationItem ContactMeLink => _contactNavigationLink;
	public NavigationItem ContactMeLinkAccent => _contactNavigationLinkAccent;
	public NavigationItem CheckMyProjectsLink => _projectsNavigationLink;
	public HomePageContentInfo HomePageContent => _homePageContentInfo;
}
