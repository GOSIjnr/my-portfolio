namespace MyPortfolio.Core.Options;

public class ImageLoaderOptions
{
	public required string ElementId { get; init; }
	public string? CssProperty { get; init; }
	public required string ImageUrl { get; init; }
	public required string FallbackUrl { get; init; }
	public bool UseVariable { get; init; }
}
