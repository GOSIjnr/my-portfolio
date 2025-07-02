using System.ComponentModel.DataAnnotations;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models.Project;

public class ProjectInfo
{
	[Required] public required string Title { get; init; }
	[Required] public required string Description { get; init; }
	public List<string>? Technologies { get; init; }
	public string? ImageUrl { get; init; }
	public ExternalLinkInfo? LiveLink { get; init; }
	public List<ExternalLinkInfo>? OtherLinks { get; init; }
}
