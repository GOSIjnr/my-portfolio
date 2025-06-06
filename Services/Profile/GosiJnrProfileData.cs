using MyPortfolio.Models.Service;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Services.Contracts;
using MyPortfolio.Models.Common;
using MyPortfolio.Core.Enum;

namespace MyPortfolio.Services.Profile;

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

	public BrandInfo Brand => _brandInfo;
	public string ProfileImageUrl => _profileImageUrl;
	public string AboutMeTitle => _aboutMeSectionTitle;
	public string AboutMeDescription => _aboutMeSectionDescription;
	public List<LinkInfo> SocialLinks => _socialMediaIconList;
	public List<ServiceInfo> ServiceInfos => _serviceInfoList;
	public List<LinkInfo> ContactInfos => _contactInfoList;
	public List<ProjectInfo> ProjectInfos => _projectInfoList;
}
