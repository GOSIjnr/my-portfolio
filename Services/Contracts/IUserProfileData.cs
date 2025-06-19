using MyPortfolio.Models.Service;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.InfoCard;
using MyPortfolio.Models.Home;

namespace MyPortfolio.Services.Contracts;

public interface IUserProfileData
{
	BrandInfo Brand { get; }
	string ProfileImageUrl { get; }
	List<LinkInfo> SocialLinks { get; }
	List<ServiceInfo> ServiceInfos { get; }
	List<LinkInfo> ContactInfos { get; }
	List<ProjectInfo> ProjectInfos { get; }
	AboutMeInfo AboutMeInfo { get; }
	List<InfoEventBase> ExperienceEvents { get; }
	List<InfoEventBase> EducationEvents { get; }
	List<SkillInfo> SkillInfos { get; }
	List<HomeStatItem> HomeStatsInfo { get; }
	string ResumeDocID { get; }
	HomePageContentInfo HomePageContent { get; }
}
