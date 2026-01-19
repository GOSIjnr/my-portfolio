using MyPortfolio.Models.Common;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Contracts.Layout;

public interface IAppLayoutData
{
	List<NavigationLinkInfo> NavigationLinks { get; init; }
	NavigationLinkInfo ContactMeLink { get; init; }
	NavigationLinkInfo DownloadCVLink { get; init; }
	NavigationLinkInfo ProjectsLink { get; init; }
	ContactFormInfo ContactForm { get; init; }
	ResumeHeaderInfo ResumeHeader { get; init; }
	List<TabButtonInfo> ResumeTabs { get; init; }
}
