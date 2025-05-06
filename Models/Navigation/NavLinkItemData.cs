namespace MyPortfolio.Models.Navigation;

public class NavLinkItemData(string displayText, string targetUrl, string cssClassName)
{
	private string _displayText = displayText;
	private string _targetUrl = SanitizeTargetUrl(targetUrl);
	private string _cssClassName = cssClassName;

	public string DisplayText
	{
		get => _displayText;
		set => _displayText = value;
	}

	public string TargetUrl
	{
		set => _targetUrl = SanitizeTargetUrl(value);
	}

	public string CssClassName
	{
		get => _cssClassName;
		set => _cssClassName = value;
	}

	public string GetFormattedTargetUrl(TargetUrlFormat format)
	{
		return format switch
		{
			TargetUrlFormat.Plain => _targetUrl,
			TargetUrlFormat.HashPrefix => $"#{_targetUrl}",
			TargetUrlFormat.SlashPrefix => $"/{_targetUrl}",
			_ => _targetUrl,
		};
	}

	private static string SanitizeTargetUrl(string url)
	{
		if (string.IsNullOrEmpty(url)) return string.Empty;

		int index = 0;

		while (index < url.Length && (url[index] == '#' || url[index] == '/'))
		{
			index++;
		}

		return url[index..];
	}
}
