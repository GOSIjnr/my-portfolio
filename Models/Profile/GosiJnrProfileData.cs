using MyPortfolio.Contracts;
using MyPortfolio.Models.UI;
using MyPortfolio.Models.Service;
using MyPortfolio.Models.Project;
using MyPortfolio.Helpers.Navigation;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models.Profile;

public class GosiJnrProfileData : IUserProfileData
{
	private static readonly BrandInfo _brandInfo = new("GOSI", "jnr.", string.Empty);
	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";

	private const string _aboutMeSectionTitle = "Hi, I'm Chinedu Victor Awugosi — a developer passionate about creating seamless user experiences, solving complex problems, and occasionally exploring game engines for fun.";

	private const string _aboutMeSectionDescription = "I'm passionate about creating digital experiences, from solving intricate technical challenges to crafting smooth, intuitive interfaces. What started as a curiosity has evolved into a passion of mine. Outside of development, I explore new technologies and brainstorm game ideas. This portfolio showcases the work I love and the projects I've built — thanks for visiting.";

	private static readonly List<LinkInfo> _socialMediaIconList =
	[
		new("https://api.iconify.design/simple-icons/github.svg", "Github", "GOSIjnr", "https://github.com/GOSIjnr", LinkType.Link),
		new("https://api.iconify.design/simple-icons/discord.svg", "Discord", "GOSIjnr", "https://discord.com/users/GOSIjnr", LinkType.Link),
		new("https://api.iconify.design/simple-icons/x.svg", "X", "@GOSIjnr", "https://twitter.com/GOSIjnr", LinkType.Link),
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
			"ESUT Brain Trainer is a mobile app designed to improve cognitive skills through fun, interactive quizzes and games. Built as a final year project at ESUT (Enugu State University of Science and Technology), the app features logic, math, memory, and vocabulary challenges to help users train their brain and track progress over time.",
			["Godot", "GDScript"],
			"images/icon.svg",
			new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Esut Brain Trainer", "https://github.com/GOSIjnr/esut-brain-trainer/releases", LinkType.Link),
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Esut Brain Trainer", "https://github.com/GOSIjnr/esut-brain-trainer"),
			]
		),
		new(
			"User Management API",
			"The User Management API is a RESTful API built with ASP.NET Core, designed to manage user data. It provides endpoints for creating, reading, updating, and deleting user records. The API is structured with a clean separation of concerns, utilizing middleware for cross-cutting concerns and a service layer for business logic.",
			["C#", "ASP.NET Core"],
			"images/icon.svg",
			null,
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "User Management API", "https://github.com/GOSIjnr/user-management-api", LinkType.Link),
			]
		),
		new(
			"Expense Tracker API",
			"Expense Tracker API is a simple and efficient API for managing personal expenses. It supports categorization, transaction tracking, and reporting, helping users monitor their spending. Built with C#, ASP.NET Core, and MySQL, it's reliable and easy to integrate with finance apps.",
			["C#", "ASP.NET Core", "My SQL"],
			"images/icon.svg",
			null,
			[
				new("https://api.iconify.design/simple-icons/github.svg", "GitHub", "Expense Tracker API", "https://github.com/GOSIjnr/expense-tracker-api", LinkType.Link),
			]
		),
	];

	public BrandInfo Brand => _brandInfo;
	public string ProfileImageUrl => _profileImageUrl;
	public string AboutMeTitle => _aboutMeSectionTitle;
	public string AboutMeDescription => _aboutMeSectionDescription;
	public List<LinkInfo> SocialLinks => _socialMediaIconList;
	public List<ServiceInfo> ServiceInfos => _serviceInfoList;
	public List<LinkInfo> ContactInfos => _contactInfoList;
	public List<ProjectInfo> ProjectInfos => _projectInfoList;
}
