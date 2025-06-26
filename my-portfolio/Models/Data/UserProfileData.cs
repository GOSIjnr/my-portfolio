using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Contracts.Profile;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Service;

namespace MyPortfolio.Models.Data;

public class UserProfileData : IUserProfileData
{
	public required BrandInfo Brand { get; init; }
	public required string ProfileImageUrl { get; init; }
	public required List<ExternalLinkInfo> SocialLinks { get; init; }
	public required List<ServiceInfo> Services { get; init; }
	public required List<ExternalLinkInfo> ContactLinks { get; init; }
	public required List<ProjectInfo> Projects { get; init; }
	public required AboutMeInfo AboutMeInfo { get; init; }
	public required List<InfoEventBase> ExperienceEvents { get; init; }
	public required List<InfoEventBase> EducationEvents { get; init; }
	public required List<SkillInfo> Skills { get; init; }
	public required List<StatInfo> Stats { get; init; }
	public required string ResumeDocID { get; init; }
	public required HomePageContentInfo HomePageContent { get; init; }
}
