using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.Navigation;

public class ExternalLinkInfo
{
	public string? IconUrl { get; init; }
	public string? Title { get; init; }
	public string? Detail { get; init; }
	public required string LinkUrl { get; init; }
	public ExternalLinkType ExternalLinkType { get; init; }

	public static ExternalLinkInfo Default => new()
	{
		IconUrl = "images/web.svg",
		Title = "Lorem ipsum",
		Detail = "Lorem ipsum dolor",
		LinkUrl = string.Empty,
		ExternalLinkType = ExternalLinkType.Text
	};
}
