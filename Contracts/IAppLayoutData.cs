using MyPortfolio.Models.UI;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Contracts;

public interface IAppLayoutData
{
	BrandInfo BrandInfo { get; }
	List<NavigationItem> NavigationLinks { get; }
	NavigationItem ContactLink { get; }
	NavigationItem ContactLinkAccent { get; }
	NavigationItem ProjectsLink { get; }
	HomePageContentInfo HomePageContent { get; }
	string ProfileImageUrl { get; }
	string ProfileImageAltText { get; }
	string AboutMeSectionTitle { get; }
	string AboutMeSectionDescription { get; }
	List<SocialMediaIconInfo> SocialMediaIcons { get; }
}
