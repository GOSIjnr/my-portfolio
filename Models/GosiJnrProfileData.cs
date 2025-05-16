using MyPortfolio.Contracts;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.UI;

namespace MyPortfolio.Models;

public class GosiJnrProfileData : IAppLayoutData
{
	private static readonly BrandInfo _brandInfo = new("GOSI", "jnr.", string.Empty);

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

	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";
	private const string _profileImageAltText = "Chinedu Victor Awugosi";
	private const string _aboutMeSectionTitle = "Hi, I'm Chinedu Victor Awugosi — a developer passionate about creating seamless user experiences, solving complex problems, and occasionally exploring game engines for fun.";
	private const string _aboutMeSectionDescription = "I'm passionate about creating digital experiences, from solving intricate technical challenges to crafting smooth, intuitive interfaces. What started as a curiosity has evolved into a passion of mine. Outside of development, I explore new technologies and brainstorm game ideas. This portfolio showcases the work I love and the projects I've built — thanks for visiting.";

	private static readonly List<SocialMediaIconInfo> _socialMediaIconList =
	[
		new("Github", "images/github.svg", "https://github.com/GOSIjnr", "Github"),
		new("Discord", "images/discord.svg", "https://discord.com/users/GOSIjnr", "Discord"),
		new("Twitter", "images/twitter.svg", "https://twitter.com/GOSIjnr", "Twitter"),
	];

	public BrandInfo BrandInfo { get; } = _brandInfo;
	public List<NavigationItem> NavigationLinks { get; } = _navigationLinks;
	public NavigationItem ContactLink { get; } = _contactNavigationLink;
	public NavigationItem ContactLinkAccent { get; } = _contactNavigationLinkAccent;
	public NavigationItem ProjectsLink { get; } = _projectsNavigationLink;
	public HomePageContentInfo HomePageContent { get; } = _homePageContentInfo;
	public string ProfileImageUrl { get; } = _profileImageUrl;
	public string ProfileImageAltText { get; } = _profileImageAltText;
	public string AboutMeSectionTitle { get; } = _aboutMeSectionTitle;
	public string AboutMeSectionDescription { get; } = _aboutMeSectionDescription;
	public List<SocialMediaIconInfo> SocialMediaIcons { get; } = _socialMediaIconList;
}
