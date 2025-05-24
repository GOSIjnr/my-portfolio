using MyPortfolio.Models.UI;
using MyPortfolio.Models.Service;

namespace MyPortfolio.Contracts;

public interface IUserProfileData
{
	BrandInfo Brand { get; }
	string ProfileImageUrl { get; }
	string AboutMeTitle { get; }
	string AboutMeDescription { get; }
	List<SocialMediaIconInfo> SocialLinks { get; }
	List<ServiceInfo> ServiceInfos { get; }
}
