namespace MyPortfolio.Models.Common;

public class BrandInfo
{
	public required string BrandDisplayName { get; init; }
	public string? BrandHighlightedDisplayName { get; init; }
	public string? BrandRawTargetUrl { get; init; }

	public static BrandInfo Default => new()
	{
		BrandDisplayName = "Lorem",
		BrandHighlightedDisplayName = "ipsum",
		BrandRawTargetUrl = string.Empty
	};
}
