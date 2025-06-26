using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models.Project;

public class ProjectInfo
{
	public required string Title { get; init; }
	public required string Description { get; init; }
	public List<string>? Technologies { get; init; }
	public string? ImageUrl { get; init; }
	public ExternalLinkInfo? LiveLink { get; init; }
	public List<ExternalLinkInfo>? OtherLinks { get; init; }

	public static ProjectInfo Default => new()
	{
		Title = "Lorem ipsum",
		Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
		Technologies = ["Lorem ipsum"],
		ImageUrl = "images/no-image.svg",
		LiveLink = null,
		OtherLinks = []
	};
}
