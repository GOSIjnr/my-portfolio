using System.ComponentModel.DataAnnotations;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.Navigation;

public class NavigationLinkInfo
{
	[Required] public required string DisplayText { get; init; }
	[Required] public required string RawTargetUrl { get; init; }
	[Required] public NavigationItemCssType CssClassType { get; init; }
	[Required] public NavigationItemCssActiveType CssActiveClassType { get; init; }
}
