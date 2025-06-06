namespace MyPortfolio.Core.Options;

public class ImageLoaderOptions
{
	public required string ElementId { get; set; }
	public string? CssProperty { get; set; }
	public required string ImageUrl { get; set; }
	public required string FallbackUrl { get; set; }
	public bool UseVariable { get; set; } = false;
}
