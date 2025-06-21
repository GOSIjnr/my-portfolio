using MyPortfolio.Core.Enum;
using MyPortfolio.Models.Contact;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;
using MyPortfolio.Services.Contracts;

namespace MyPortfolio.Services.Profile;

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

	private readonly NavigationItem _downloadCVLink = new("Download CV", "", NavigationItemCssType.Rounded, NavigationItemCssActiveType.Normal);

	private static readonly NavigationItem _projectsNavigationLink = new("Check My Works", "projects", NavigationItemCssType.RoundedInverted, NavigationItemCssActiveType.Normal);

	private static readonly ContactFormLayout _contactFormContent = new("Let's Collaborate", "I'm excited to hear about your project and how we can create something amazing together. Whether you have questions, ideas, or just want to say hello, feel free to reach out!");

	public static readonly ResumeHeaderLayoutData _resumeHeaderLayoutData = new("Why hire me?", "Browse through the areas below to learn more about my skills and experience.");

	public static readonly List<ResumeTabItemLayoutData> _resumeTabItemLayoutData =
	[
		new("About Me"),
		new("Education"),
		new("Experience"),
		new("Skills"),
	];

	public static readonly string _experienceSubTitle = "My journey has been shaped by a variety of experiences—some planned, some unexpected—all of which have helped me grow into who I am today. Each role has left its mark, teaching me something new about myself and the world around me.";

	public static readonly string _educationSubTitle = "Education has been the foundation of my growth, providing me with the tools to think critically, solve problems, and explore new ideas. Every step along the way has opened new doors, fueling my curiosity and shaping the way I approach the world.";

	public static readonly string _skillsSubTitle = "The skills I've developed reflect both my passions and my commitment to continuous learning. Each one represents countless hours of curiosity, experimentation, and practice—tools that help me bring ideas to life and tackle challenges with confidence.";

	public List<NavigationItem> NavigationLinks => _navigationLinks;
	public NavigationItem ContactMeLink => _contactNavigationLink;
	public NavigationItem DownloadCVLink => _downloadCVLink;
	public NavigationItem CheckMyProjectsLink => _projectsNavigationLink;
	public ContactFormLayout ContactFormContent => _contactFormContent;
	public ResumeHeaderLayoutData ResumeHeaderLayoutData => _resumeHeaderLayoutData;
	public List<ResumeTabItemLayoutData> ResumeTabItemLayoutData => _resumeTabItemLayoutData;
	public string ExperienceSectionBody => _experienceSubTitle;
	public string EducationSectionBody => _educationSubTitle;
	public string SkillSectionBody => _skillsSubTitle;
}
