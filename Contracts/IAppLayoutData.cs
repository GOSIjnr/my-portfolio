using MyPortfolio.Models.Contact;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Contracts;

public interface IAppLayoutData
{
	List<NavigationItem> NavigationLinks { get; }
	NavigationItem ContactMeLink { get; }
	NavigationItem ContactMeLinkAccent { get; }
	NavigationItem CheckMyProjectsLink { get; }
	HomePageContentInfo HomePageContent { get; }
	ContactFormLayout ContactFormContent { get; }
}
