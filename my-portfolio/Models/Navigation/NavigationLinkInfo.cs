using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.Navigation;

public class NavigationLinkInfo
{
	public required string DisplayText { get; init; }
	public required string RawTargetUrl { get; init; }
	public NavigationItemCssType CssClassType { get; init; }
	public NavigationItemCssActiveType CssActiveClassType { get; init; }

	public static NavigationLinkInfo Default => new()
	{
		DisplayText = "Lorem ipsum",
		RawTargetUrl = "https://example.com",
		CssClassType = NavigationItemCssType.Normal,
		CssActiveClassType = NavigationItemCssActiveType.Normal
	};
}
