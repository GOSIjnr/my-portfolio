using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Models.Project;

public class ProjectInfo(string title, string description, List<string> technologies, string imageUrl, LinkInfo? liveLink, List<LinkInfo> otherLinks)
{
	private string _title = title ?? string.Empty;
	private string _description = description ?? string.Empty;
	private List<string> _technologies = technologies ?? [];
	private string _imageUrl = imageUrl ?? string.Empty;
	private LinkInfo? _liveLink = liveLink;
	private List<LinkInfo> _otherLinks = otherLinks ?? [];

	public string Title
	{
		get => _title;
		set => _title = value ?? string.Empty;
	}

	public string Description
	{
		get => _description;
		set => _description = value ?? string.Empty;
	}

	public List<string> Technologies
	{
		get => [.. _technologies.Where(x => !string.IsNullOrEmpty(x))];
		set => _technologies = value ?? [];
	}

	public string ImageUrl
	{
		get => _imageUrl;
		set => _imageUrl = value ?? string.Empty;
	}

	public LinkInfo? LiveLink
	{
		get => _liveLink;
		set => _liveLink = value;
	}

	public List<LinkInfo> OtherLinks
	{
		get => [.. _otherLinks.Where(x => x is not null)];
		set => _otherLinks = value ?? [];
	}

	public ProjectInfo() : this("Lorem ispum", "dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ["Lorem ispum"], "images/icon.svg", null, []) { }
}