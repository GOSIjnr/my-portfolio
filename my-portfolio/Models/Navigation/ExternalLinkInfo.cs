using System.ComponentModel.DataAnnotations;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.Navigation;

public class ExternalLinkInfo
{
	public string? IconUrl { get; init; }
	public string? Title { get; init; }
	public string? Detail { get; init; }
	[Required] public required string LinkUrl { get; init; }
	[Required] public ExternalLinkType ExternalLinkType { get; init; }

	public static readonly ExternalLinkInfo Default = new()
	{
		LinkUrl = string.Empty,
	};
}
