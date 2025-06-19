using MyPortfolio.Models.Service;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Services.Contracts;
using MyPortfolio.Models.Common;
using MyPortfolio.Core.Enum;
using MyPortfolio.Models.InfoCard;
using MyPortfolio.Models.Home;

namespace MyPortfolio.Services.Profile;

public class DefualtProfileData : IUserProfileData
{
	private static readonly BrandInfo _brandInfo = new();
	private const string _profileImageUrl = "images/no-image.svg";

	private static readonly List<LinkInfo> _socialMediaIconList =
	[
		new(),
		new(),
		new(),
	];

	private static readonly List<ServiceInfo> _serviceInfoList =
	[
		new(),
		new(),
	];

	private static readonly List<LinkInfo> _contactInfoList =
	[
		new(),
	];

	private static readonly List<ProjectInfo> _projectInfoList =
	[
		new(),
		new(),
	];

	private static readonly AboutMeInfo _aboutMeInfo = new();

	private static readonly List<InfoEventBase> _experienceEvents =
	[
		new DoubleDateEvent(),
		new SingleDateEvent(),
	];

	private static readonly List<InfoEventBase> _educationEvents =
	[
		new DoubleDateEvent(),
		new SingleDateEvent(),
		new SingleDateEvent(),
	];

	private static readonly List<SkillInfo> _skillInfos =
	[
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
		new(),
	];

	private static readonly List<HomeStatItem> _homeStatsInfo =
	[
		new(),
		new(),
		new(),
		new(),
	];

	private static readonly string _resumeDocID = string.Empty;

	private static readonly HomePageContentInfo _homePageContentInfo = new();

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
