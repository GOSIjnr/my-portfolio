using MyPortfolio.Models;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Contracts;

public interface IAppLayoutData
{
	NavigationBrandInfo NavigationBrandInfo { get; }
	List<NavigationLinkItemInfo> NavigationLinks { get; }
	NavigationLinkItemInfo ContactLink { get; }
	NavigationLinkItemInfo ContactLinkAccent { get; }
	NavigationLinkItemInfo ProjectsLink { get; }
	HomePageContentInfo HomePageContent { get; }
	string ProfileImageUrl { get; }
	string ProfileImageAltText { get; }
	string AboutMeSectionTitle { get; }
	string AboutMeSectionDescription { get; }
	List<SocialMediaIconInfo> SocialMediaIcons { get; }
}
