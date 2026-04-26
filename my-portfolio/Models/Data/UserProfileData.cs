using System.ComponentModel.DataAnnotations;
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
	[Required] public required BrandInfo Brand { get; init; }
	[Required] public required string ProfileImageUrl { get; init; }
	[Required] public required List<ExternalLinkInfo> SocialLinks { get; init; }
	[Required] public required List<ServiceInfo> Services { get; init; }
	[Required] public required List<ExternalLinkInfo> ContactLinks { get; init; }
	[Required] public required List<ProjectInfo> Projects { get; init; }
	[Required] public required AboutMeInfo AboutMeInfo { get; init; }
	[Required] public required List<InfoEventBase> ExperienceEvents { get; init; }
	[Required] public required List<InfoEventBase> EducationEvents { get; init; }
	[Required] public required List<SkillInfo> Skills { get; init; }
	[Required, MinLength(1), MaxLength(4)] public required List<StatInfo> Stats { get; init; }
	[Required] public required string ResumeDocID { get; init; }
	[Required] public required HomePageContentInfo HomePageContent { get; init; }
	[Required] public required ResumeSectionIntro ResumeSectionIntro { get; init; }
}
