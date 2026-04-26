using System.ComponentModel.DataAnnotations;
using MyPortfolio.Contracts.Layout;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Models.Data;

public class AppLayoutData : IAppLayoutData
{
	[Required, MinLength(1), MaxLength(5)] public required List<NavigationLinkInfo> NavigationLinks { get; init; }
	[Required] public required NavigationLinkInfo ContactMeLink { get; init; }
	[Required] public required NavigationLinkInfo DownloadCVLink { get; init; }
	[Required] public required NavigationLinkInfo ProjectsLink { get; init; }
	[Required] public required ContactFormInfo ContactForm { get; init; }
	[Required] public required ResumeHeaderInfo ResumeHeader { get; init; }
	[Required, MinLength(1), MaxLength(4)] public required List<TabButtonInfo> ResumeTabs { get; init; }
}