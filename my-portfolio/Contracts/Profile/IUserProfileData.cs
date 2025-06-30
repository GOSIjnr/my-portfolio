using MyPortfolio.Models.Service;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Home;
using MyPortfolio.Contracts.InfoCard;

namespace MyPortfolio.Contracts.Profile;

public interface IUserProfileData
{
	BrandInfo Brand { get; init; }
	string ProfileImageUrl { get; init; }
	List<ExternalLinkInfo> SocialLinks { get; init; }
	List<ServiceInfo> Services { get; init; }
	List<ExternalLinkInfo> ContactLinks { get; init; }
	List<ProjectInfo> Projects { get; init; }
	AboutMeInfo AboutMeInfo { get; init; }
	List<InfoEventBase> ExperienceEvents { get; init; }
	List<InfoEventBase> EducationEvents { get; init; }
	List<SkillInfo> Skills { get; init; }
	List<StatInfo> Stats { get; init; }
	string ResumeDocID { get; init; }
	HomePageContentInfo HomePageContent { get; init; }
	ResumeSectionIntro ResumeSectionIntro { get; init; }
}
