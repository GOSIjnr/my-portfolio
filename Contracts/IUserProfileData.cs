using MyPortfolio.Models.UI;
using MyPortfolio.Models.Service;
using MyPortfolio.Models.Contact;

namespace MyPortfolio.Contracts;

public interface IUserProfileData
{
	BrandInfo Brand { get; }
	string ProfileImageUrl { get; }
	string AboutMeTitle { get; }
	string AboutMeDescription { get; }
	List<ContactInfo> SocialLinks { get; }
	List<ServiceInfo> ServiceInfos { get; }
	List<ContactInfo> ContactInfos { get; }
}
