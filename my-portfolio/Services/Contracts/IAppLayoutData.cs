using MyPortfolio.Models.Contact;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Services.Contracts;

public interface IAppLayoutData
{
	List<NavigationItem> NavigationLinks { get; }
	NavigationItem ContactMeLink { get; }
	NavigationItem DownloadCVLink { get; }
	NavigationItem CheckMyProjectsLink { get; }
	ContactFormLayout ContactFormContent { get; }
	ResumeHeaderLayoutData ResumeHeaderLayoutData { get; }
	List<ResumeTabItemLayoutData> ResumeTabItemLayoutData { get; }
	string ExperienceSectionBody { get; }
	string EducationSectionBody { get; }
	string SkillSectionBody { get; }
}
