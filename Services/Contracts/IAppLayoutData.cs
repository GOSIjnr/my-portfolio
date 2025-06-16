using MyPortfolio.Models.Contact;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Services.Contracts;

public interface IAppLayoutData
{
	List<NavigationItem> NavigationLinks { get; }
	NavigationItem ContactMeLink { get; }
	NavigationItem ContactMeLinkAccent { get; }
	NavigationItem CheckMyProjectsLink { get; }
	HomePageContentInfo HomePageContent { get; }
	ContactFormLayout ContactFormContent { get; }
	ResumeHeaderLayoutData ResumeHeaderLayoutData { get; }
	List<ResumeTabItemLayoutData> ResumeTabItemLayoutData { get; }
	string ExperienceSectionBody { get; }
	string EducationSectionBody { get; }
}
