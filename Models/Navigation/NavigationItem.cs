using MyPortfolio.Helpers.Utilities;

namespace MyPortfolio.Models.Navigation;

public class NavigationItem(string displayText, string rawTargetUrl, NavigationItemCssType cssClassType, NavigationItemCssActiveType cssActiveClassType)
{
	private string _displayText = displayText ?? string.Empty;
	private string _rawTargetUrl = rawTargetUrl ?? string.Empty;
	private NavigationItemCssType _cssClassType = EnumValidator.ValidateOrDefault(cssClassType, NavigationItemCssType.Normal);
	private NavigationItemCssActiveType _cssActiveClassType = EnumValidator.ValidateOrDefault(cssActiveClassType, NavigationItemCssActiveType.Normal);

	public string DisplayText
	{
		get => _displayText;
		set => _displayText = value ?? string.Empty;
	}

	public string RawTargetUrl
	{
		get => _rawTargetUrl;
		set => _rawTargetUrl = value ?? string.Empty;
	}

	public NavigationItemCssType CssClassType
	{
		get => _cssClassType;
		set => _cssClassType = EnumValidator.ValidateOrDefault(cssClassType, NavigationItemCssType.Normal);
	}

	public NavigationItemCssActiveType CssActiveClassType
	{
		get => _cssActiveClassType;
		set => _cssActiveClassType = EnumValidator.ValidateOrDefault(cssActiveClassType, NavigationItemCssActiveType.Normal);
	}

	public NavigationItem() : this("Lorem ispum", string.Empty, NavigationItemCssType.Normal, NavigationItemCssActiveType.Normal) { }
}
