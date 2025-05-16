namespace MyPortfolio.Models.UI;

public class BrandInfo(string brandDisplayName, string brandHighlightedDisplayName, string brandRawTargetUrl)
{
	private string _brandDisplayName = brandDisplayName;
	private string _brandHighlightedDisplayName = brandHighlightedDisplayName;
	private string _brandRawTargetUrl = brandRawTargetUrl;

	public string BrandDisplayName
	{
		get => _brandDisplayName;
		set => _brandDisplayName = value ?? string.Empty;
	}

	public string BrandHighlightedDisplayName
	{
		get => _brandHighlightedDisplayName;
		set => _brandHighlightedDisplayName = value ?? string.Empty;
	}

	public string BrandRawTargetUrl
	{
		get => _brandRawTargetUrl;
		set => _brandRawTargetUrl = value ?? string.Empty;
	}

	public BrandInfo() : this("Lorem ", "ipsum", string.Empty) { }
}
