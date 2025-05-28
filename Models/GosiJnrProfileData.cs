using MyPortfolio.Contracts;
using MyPortfolio.Models.UI;
using MyPortfolio.Models.Service;
using MyPortfolio.Models.Contact;
using MyPortfolio.Helpers.Contact;

namespace MyPortfolio.Models;

public class GosiJnrProfileData : IUserProfileData
{
	private static readonly BrandInfo _brandInfo = new("GOSI", "jnr.", string.Empty);
	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";

	private const string _aboutMeSectionTitle = "Hi, I'm Chinedu Victor Awugosi — a developer passionate about creating seamless user experiences, solving complex problems, and occasionally exploring game engines for fun.";

	private const string _aboutMeSectionDescription = "I'm passionate about creating digital experiences, from solving intricate technical challenges to crafting smooth, intuitive interfaces. What started as a curiosity has evolved into a passion of mine. Outside of development, I explore new technologies and brainstorm game ideas. This portfolio showcases the work I love and the projects I've built — thanks for visiting.";

	private static readonly List<ContactInfo> _socialMediaIconList =
	[
		new("https://api.iconify.design/simple-icons/github.svg", "Github", "GOSIjnr", "https://github.com/GOSIjnr", ContactType.Link),
		new("https://api.iconify.design/simple-icons/discord.svg", "Discord", "GOSIjnr", "https://discord.com/users/GOSIjnr", ContactType.Link),
		new("https://api.iconify.design/simple-icons/x.svg", "X", "@GOSIjnr", "https://twitter.com/GOSIjnr", ContactType.Link),
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

	private static readonly List<ContactInfo> _contactInfoList =
	[
		new("https://api.iconify.design/solar/letter-bold.svg", "Email", "gosijnr7@yahoo.com", "gosijnr7@yahoo.com", ContactType.Email),
		new("https://api.iconify.design/solar/letter-bold.svg", "Email (secondary)", "gosijnr7@gmail.com", "gosijnr7@gmail.com",ContactType.Email),
	];

	public BrandInfo Brand => _brandInfo;
	public string ProfileImageUrl => _profileImageUrl;
	public string AboutMeTitle => _aboutMeSectionTitle;
	public string AboutMeDescription => _aboutMeSectionDescription;
	public List<ContactInfo> SocialLinks => _socialMediaIconList;
	public List<ServiceInfo> ServiceInfos => _serviceInfoList;
	public List<ContactInfo> ContactInfos => _contactInfoList;
}
