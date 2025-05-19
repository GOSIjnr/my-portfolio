using MyPortfolio.Contracts;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public class PortfolioLayoutData : IAppLayoutData
{
	private static readonly List<NavigationItem> _navigationLinks =
	[
		new("Home", string.Empty, NavigationItemCssType.Rounded, NavigationItemCssActiveType.UnderLine),
		new("Services", "services", NavigationItemCssType.Normal, NavigationItemCssActiveType.UnderLine),
		new("Resume", "resume", NavigationItemCssType.Normal, NavigationItemCssActiveType.UnderLine),
		new("Projects", "projects", NavigationItemCssType.Normal, NavigationItemCssActiveType.UnderLine),
		new("Contact", "contact", NavigationItemCssType.Normal, NavigationItemCssActiveType.UnderLine),
	];

	private static readonly NavigationItem _contactNavigationLink = new("Let's Connect", "contact", NavigationItemCssType.Rounded, NavigationItemCssActiveType.Normal);
	private static readonly NavigationItem _contactNavigationLinkAccent = new("Let's Connect", "contact", NavigationItemCssType.RoundedInverted, NavigationItemCssActiveType.Normal);
	private static readonly NavigationItem _projectsNavigationLink = new("Check My Works", "projects", NavigationItemCssType.Rounded, NavigationItemCssActiveType.Normal);

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
