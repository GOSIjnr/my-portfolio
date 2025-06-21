namespace MyPortfolio.Models.Common;

public record BrandInfo(string? BrandDisplayName, string? BrandHighlightedDisplayName, string? BrandRawTargetUrl)
{
	public static BrandInfo Default => new("Lorem", "ipsum", string.Empty);
}
