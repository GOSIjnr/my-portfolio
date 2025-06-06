namespace MyPortfolio.Models.Home;

public class HomePageContentInfo(string mainTitle, string highlightedTitlePart, string descriptionBody, string backgroundImagePath)
{
	private string _mainTitle = mainTitle ?? string.Empty;
	private string _highlightedTitlePart = highlightedTitlePart ?? string.Empty;
	private string _descriptionBody = descriptionBody ?? string.Empty;
	private string _backgroundImagePath = backgroundImagePath ?? string.Empty;

	public string MainTitle
	{
		get => _mainTitle;
		set => _mainTitle = value ?? string.Empty;
	}

	public string HighlightedTitlePart
	{
		get => _highlightedTitlePart;
		set => _highlightedTitlePart = value ?? string.Empty;
	}

	public string DescriptionBody
	{
		get => _descriptionBody;
		set => _descriptionBody = value ?? string.Empty;
	}

	public string BackgroundImagePath
	{
		get => _backgroundImagePath;
		set => _backgroundImagePath = value ?? string.Empty;
	}

	public HomePageContentInfo() : this("Lorem", "ipsum", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", string.Empty) { }
}
