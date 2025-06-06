using MyPortfolio.Contracts;
using MyPortfolio.Models.Contact;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Models.Profile;

public class PortfolioLayoutData : IAppLayoutData
{
	private static readonly List<NavigationItem> _navigationLinks =
	[
		new("Home", string.Empty, NavigationItemCssType.Normal, NavigationItemCssActiveType.UnderLine),
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

	private static readonly ContactFormLayout _contactFormContent = new("Let's Collaborate", "I'm excited to hear about your project and how we can create something amazing together. Whether you have questions, ideas, or just want to say hello, feel free to reach out!");

	public static readonly ResumeHeaderLayoutData _resumeHeaderLayoutData = new("Why hire me?", "Browse through the areas below to learn more about my skills and experience.");

	public static readonly List<ResumeTabItemLayoutData> _resumeTabItemLayoutData =
	[
		new("About Me"),
		new("Experience"),
		new("Skills"),
	];

	public List<NavigationItem> NavigationLinks => _navigationLinks;
	public NavigationItem ContactMeLink => _contactNavigationLink;
	public NavigationItem ContactMeLinkAccent => _contactNavigationLinkAccent;
	public NavigationItem CheckMyProjectsLink => _projectsNavigationLink;
	public HomePageContentInfo HomePageContent => _homePageContentInfo;
	public ContactFormLayout ContactFormContent => _contactFormContent;
	public ResumeHeaderLayoutData ResumeHeaderLayoutData => _resumeHeaderLayoutData;
	public List<ResumeTabItemLayoutData> ResumeTabItemLayoutData => _resumeTabItemLayoutData;
}
