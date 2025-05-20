using MyPortfolio.Contracts;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.UI;

namespace MyPortfolio.Models;

public class GosiJnrProfileData : IUserProfileData
{
	private static readonly BrandInfo _brandInfo = new("GOSI", "jnr.", string.Empty);
	private const string _profileImageUrl = "https://github.com/GOSIjnr.png";
	private const string _aboutMeSectionTitle = "Hi, I'm Chinedu Victor Awugosi — a developer passionate about creating seamless user experiences, solving complex problems, and occasionally exploring game engines for fun.";
	private const string _aboutMeSectionDescription = "I'm passionate about creating digital experiences, from solving intricate technical challenges to crafting smooth, intuitive interfaces. What started as a curiosity has evolved into a passion of mine. Outside of development, I explore new technologies and brainstorm game ideas. This portfolio showcases the work I love and the projects I've built — thanks for visiting.";

	private static readonly List<SocialMediaIconInfo> _socialMediaIconList =
	[
		new("Github", "images/github.svg", "https://github.com/GOSIjnr", "Github"),
		new("Discord", "images/discord.svg", "https://discord.com/users/GOSIjnr", "Discord"),
		new("Twitter", "images/twitter.svg", "https://twitter.com/GOSIjnr", "Twitter"),
	];

	public BrandInfo Brand => _brandInfo;
	public string ProfileImageUrl => _profileImageUrl;
	public string AboutMeTitle => _aboutMeSectionTitle;
	public string AboutMeDescription => _aboutMeSectionDescription;
	public List<SocialMediaIconInfo> SocialLinks => _socialMediaIconList;
}
