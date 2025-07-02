using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class BrandInfo
{
	[Required] public required string BrandDisplayName { get; init; }
	public string? BrandHighlightedDisplayName { get; init; }
	public string? BrandRawTargetUrl { get; init; }
}
