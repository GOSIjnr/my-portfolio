namespace MyPortfolio.Models.Common;

public class BrandInfo(string brandDisplayName, string brandHighlightedDisplayName, string brandRawTargetUrl)
{
	private string _brandDisplayName = brandDisplayName ?? string.Empty;
	private string _brandHighlightedDisplayName = brandHighlightedDisplayName ?? string.Empty;
	private string _brandRawTargetUrl = brandRawTargetUrl ?? string.Empty;

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
