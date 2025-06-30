using MyPortfolio.Contracts.Layout;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Models.Data;

public class AppLayoutData : IAppLayoutData
{
	public required List<NavigationLinkInfo> NavigationLinks { get; init; }
	public required NavigationLinkInfo ContactMeLink { get; init; }
	public required NavigationLinkInfo DownloadCVLink { get; init; }
	public required NavigationLinkInfo ProjectsLink { get; init; }
	public required ContactFormInfo ContactForm { get; init; }
	public required ResumeHeaderInfo ResumeHeader { get; init; }
	public required List<TabButtonInfo> ResumeTabs { get; init; }
}
