namespace MyPortfolio.Models.UI;

public class BrandInfo(string brandDisplayName, string brandHighlightedDisplayName, string brandRawTargetUrl)
{
	public string BrandDisplayName { get; set; } = brandDisplayName ?? string.Empty;
	public string BrandHighlightedDisplayName { get; set; } = brandHighlightedDisplayName ?? string.Empty;
	public string BrandRawTargetUrl { get; set; } = brandRawTargetUrl ?? string.Empty;

	public BrandInfo() : this("Lorem ", "ipsum", string.Empty) { }
}
