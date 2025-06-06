using MyPortfolio.Models.Service;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Common;

namespace MyPortfolio.Services.Contracts;

public interface IUserProfileData
{
	BrandInfo Brand { get; }
	string ProfileImageUrl { get; }
	string AboutMeTitle { get; }
	string AboutMeDescription { get; }
	List<LinkInfo> SocialLinks { get; }
	List<ServiceInfo> ServiceInfos { get; }
	List<LinkInfo> ContactInfos { get; }
	List<ProjectInfo> ProjectInfos { get; }
}
