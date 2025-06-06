using MyPortfolio.Models.UI;
using MyPortfolio.Models.Service;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;

namespace MyPortfolio.Contracts;

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
