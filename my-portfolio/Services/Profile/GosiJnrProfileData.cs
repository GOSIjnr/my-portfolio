using MyPortfolio.Models.Service;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Services.Contracts;
using MyPortfolio.Models.Common;
using MyPortfolio.Core.Enum;
using MyPortfolio.Models.InfoCard;
using MyPortfolio.Models.Home;
using MyPortfolio.Shared.Components.Branding;

namespace MyPortfolio.Services.Profile;

public class GosiJnrProfileData : IUserProfileData
{
	private static readonly BrandInfo _brandInfo = new("Victor", ".", string.Empty);
	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";

	private static readonly List<LinkInfo> _socialMediaIconList =
	[
		new("https://api.iconify.design/simple-icons/github.svg", "Github", "GOSIjnr", "https://github.com/GOSIjnr", LinkType.Link),
		new("https://api.iconify.design/simple-icons/discord.svg", "Discord", "GOSIjnr", "https://discord.com/users/GOSIjnr", LinkType.Link),
		new("https://api.iconify.design/simple-icons/x.svg", "X", "@GOSIjnr", "https://twitter.com/GOSIjnr", LinkType.Link),
		new("https://api.iconify.design/cib/linkedin.svg", "Linkden", "Victor Awugosi", "https://www.linkedin.com/in/victor-awugosi/", LinkType.Link),
	];

	private static readonly List<ServiceInfo> _serviceInfoList =
	[
		new("Full-Stack Web Development", "I build scalable, performant web applications from front-end interfaces to back-end infrastructure using modern frameworks and tools."),
		new("Game Development", "I design and develop engaging games using Godot, Unity and other engines, focusing on gameplay mechanics, UI, and cross-platform compatibility."),
		new("Data Analysis & Visualization", "I analyze datasets to uncover insights, trends, and patterns, presenting them through clear visualizations and reports to support data-driven decisions."),
		new("Front-End Development", "I create responsive, accessible, and user-focused interfaces using HTML, CSS, JavaScript, and modern front-end frameworks like Blazor"),
		new("Back-End Development", "I develop secure, efficient APIs and server-side logic using technologies such as C# and databases like MySQL."),
		new("Graphic Design & Digital Art", "I create digital illustrations, brand assets, and visual content for web, games, and print."),
	];

	private static readonly List<LinkInfo> _contactInfoList =
	[
		new("https://api.iconify.design/solar/letter-bold.svg", "Email", "gosijnr7@yahoo.com", "gosijnr7@yahoo.com", LinkType.Email),
		new("https://api.iconify.design/solar/letter-bold.svg", "Email (secondary)", "gosijnr7@gmail.com", "gosijnr7@gmail.com",LinkType.Email),
	];

	private static readonly List<ProjectInfo> _projectInfoList =
	[
		new(
			"Esut Brain Train App",
			"A mobile app with logic, math, memory, and vocabulary games to boost cognitive skills. Built as a final-year project at ESUT.",
			["Godot", "GDScript"],
			"images/esut-brain-trainer.png",
			new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Esut Brain Trainer", "https://github.com/GOSIjnr/esut-brain-trainer/releases", LinkType.Link),
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Esut Brain Trainer", "https://github.com/GOSIjnr/esut-brain-trainer"),
			]
		),
		new(
			"User Management API",
			"A RESTful API for managing user data with CRUD operations, built using ASP.NET Core and clean architecture principles.",
			["C#", "ASP.NET Core"],
			string.Empty,
			null,
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "User Management API", "https://github.com/GOSIjnr/user-management-api", LinkType.Link),
			]
		),
		new(
			"Expense Tracker API",
			"An ASP.NET Core API for tracking expenses, with support for categories, transactions, and spending reports.",
			["C#", "ASP.NET Core", "My SQL"],
			string.Empty,
			null,
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Expense Tracker API", "https://github.com/GOSIjnr/expense-tracker-api", LinkType.Link),
			]
		),
	];

	private static readonly AboutMeInfo _aboutMeInfo = new(
		"Hi, I'm Chinedu Victor Awugosi, a developer who enjoys building smooth, intuitive digital experiences and solving technical challenges. I work across the stack, explore new tech, and occasionally dive into game engines for fun.",
		new() {
			{ "Name", "Awugosi Victor" },
			{ "Experience", "2 years" },
			{ "Nationality", "Nigerian" },
			{ "Email", "gosijnr7@yahoo.com" },
			{ "Language", "English" },
			{ "Hobbies", "Coding, gaming, and watching anime" },
		}
	);

	private static readonly List<InfoEventBase> _experienceEvents =
	[
		new DoubleDateEvent(new(2023, 8, 1), new(2023, 10, 1), "Network Operating Centre (Intern)", "InterConnect Clearing House Nigeria Limited"),
	];

	private static readonly List<InfoEventBase> _educationEvents =
	[
		new DoubleDateEvent(new(2019, 12, 10), new(2024, 10, 10), "Bachelor of Engineering, Computer Engineering", "Enugu State University of Science and Technology"),
		new SingleDateEvent(new(2025, 2, 17), "Microsoft Power BI Data Analyst", "Microsoft Corporation"),
		new SingleDateEvent(new(2025, 4, 25), "UI / UX Design", "California Institute of the Art"),
	];

	private static readonly List<SkillInfo> _skillInfos =
	[
		new("Blazor", "https://api.iconify.design/simple-icons/blazor.svg"),
		new(".NET", "https://api.iconify.design/simple-icons/dotnet.svg"),
		new("Entity Framework", "https://api.iconify.design/devicon-plain/entityframeworkcore.svg"),
		new("Unity", "https://api.iconify.design/simple-icons/unity.svg"),
		new("Godot", "https://api.iconify.design/simple-icons/godotengine.svg"),
		new("C#", "https://api.iconify.design/mdi/language-csharp.svg"),
		new("Python", "https://api.iconify.design/simple-icons/python.svg"),
		new("JavaScript", "https://api.iconify.design/simple-icons/javascript.svg"),
		new("HTML5", "https://api.iconify.design/simple-icons/html5.svg"),
		new("CSS", "https://api.iconify.design/simple-icons/css.svg"),
		new("MySQL", "https://api.iconify.design/simple-icons/mysql.svg"),
		new("Postman", "https://api.iconify.design/simple-icons/postman.svg"),
		new("Github", "https://api.iconify.design/simple-icons/github.svg"),
		new("Figma", "https://api.iconify.design/solar/figma-bold-duotone.svg"),
	];

	private static readonly List<HomeStatItem> _homeStatsInfo =
	[
		new("2", "Years of <br>experience"),
		new("3", "Projects <br>completed"),
		new("10+", "Technologies <br>mastered"),
		new("60+", "Code <br>commits")
	];

	private static readonly string _resumeDocID = "1NdPAG_6jcNHaFta0fJK6lT5TlNLzEMgQ";

	private static readonly HomePageContentInfo _homePageContentInfo = new(
		"Full-Stack / Game Developer",
		"Hello I'm",
		"Victor Awugosi",
		"I turn caffeine into code, pixels into purpose, and bugs into... features (sometimes). Code builds it, curiosity drives it."
	);

	public BrandInfo Brand => _brandInfo;
	public string ProfileImageUrl => _profileImageUrl;
	public List<LinkInfo> SocialLinks => _socialMediaIconList;
	public List<ServiceInfo> ServiceInfos => _serviceInfoList;
	public List<LinkInfo> ContactInfos => _contactInfoList;
	public List<ProjectInfo> ProjectInfos => _projectInfoList;
	public AboutMeInfo AboutMeInfo => _aboutMeInfo;
	public List<InfoEventBase> ExperienceEvents => _experienceEvents;
	public List<InfoEventBase> EducationEvents => _educationEvents;
	public List<SkillInfo> SkillInfos => _skillInfos;
	public List<HomeStatItem> HomeStatsInfo => _homeStatsInfo;
	public string ResumeDocID => _resumeDocID;
	public HomePageContentInfo HomePageContent => _homePageContentInfo;
}
