using MyPortfolio.Contracts;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models;

public class AppLayoutData : IAppLayoutData
{
	private static readonly NavigationBrandInfo _navigationBrandInfo = new("Images/icon.svg", "GOSIjnr", "Logo");

	private static readonly List<NavigationLinkItemInfo> _navigationLinks =
	[
		new("About Me", "aboutme", "nav-text"),
		new("Skills", "skills", "nav-text"),
		new("Projects", "projects", "nav-text"),
		new("Resume", "resume", "nav-text"),
	];

	private static readonly NavigationLinkItemInfo _contactNavigationLink = new("Let's Connect", "contact", "nav-button");
	private static readonly NavigationLinkItemInfo _contactNavigationLinkAccent = new("Let's Connect", "contact", "nav-button-accent");
	private static readonly NavigationLinkItemInfo _projectsNavigationLink = new("Check My Works", "projects", "nav-button");

	private static readonly HomePageContentInfo _homePageContentInfo = new(
		"Code. Design. Deploy. ",
		"Play.",
		"I turn caffeine into code, pixels into purpose, and bugs into... features (sometimes).",
		"Images/backdrop.jpg"
	);

	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";
	private const string _profileImageAltText = "Chinedu Victor Awugosi";
	private const string _aboutMeSectionTitle = "Hi, I'm Chinedu Victor Awugosi — a developer who finds just as much joy in crafting intuitive user interfaces as in unraveling complex logic behind the scenes, and occasionally diving into game engines just for the thrill of it.";
	private const string _aboutMeSectionDescription = "I've always loved creating things, especially the kind that live on a screen. What started as a curiosity turned into a full-blown passion for coding — and now, it's what I do every day. I enjoy figuring out how things work, whether that's a complex piece of back-end logic or the tiniest UI animation. Outside of development, I'm probably sketching out a game idea, exploring new tech, or just geeking out over clean, elegant code. This portfolio is a glimpse into the things I've built and the kind of work I love doing — thanks for stopping by.";

	private static readonly List<SocialMediaIconInfo> _socialMediaIconList =
	[
		new("Twitter", "Images/icon.svg", "https://twitter.com/yourprofile", "Twitter"),
		new("Facebook", "Images/icon.svg", "https://facebook.com/yourprofile", "Facebook"),
		new("Discord", "Images/icon.svg", "https://discord.com/users/yourprofile", "Discord"),
		new("YouTube", "Images/icon.svg", "https://youtube.com/yourchannel", "YouTube"),
	];

	public NavigationBrandInfo NavigationBrandInfo { get; } = _navigationBrandInfo;
	public List<NavigationLinkItemInfo> NavigationLinks { get; } = _navigationLinks;
	public NavigationLinkItemInfo ContactLink { get; } = _contactNavigationLink;
	public NavigationLinkItemInfo ContactLinkAccent { get; } = _contactNavigationLinkAccent;
	public NavigationLinkItemInfo ProjectsLink { get; } = _projectsNavigationLink;
	public HomePageContentInfo HomePageContent { get; } = _homePageContentInfo;
	public string ProfileImageUrl { get; } = _profileImageUrl;
	public string ProfileImageAltText { get; } = _profileImageAltText;
	public string AboutMeSectionTitle { get; } = _aboutMeSectionTitle;
	public string AboutMeSectionDescription { get; } = _aboutMeSectionDescription;
	public List<SocialMediaIconInfo> SocialMediaIcons { get; } = _socialMediaIconList;
}
