namespace MyPortfolio.Models.Navigation;

public class NavigationItem(string displayText, string rawTargetUrl, string cssClassName)
{
	private string _displayText = displayText ?? string.Empty;
	private string _rawTargetUrl = rawTargetUrl ?? string.Empty;
	private string _cssClassName = cssClassName ?? string.Empty;

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

	public string CssClassName
	{
		get => _cssClassName;
		set => _cssClassName = value ?? string.Empty;
	}

	public NavigationItem() : this("Lorem ispum", string.Empty, string.Empty) { }
}
