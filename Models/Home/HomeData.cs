namespace MyPortfolio.Models.Home;

public class HomeData(string mainTitle, string highlightedTitlePart, string descriptionBody, string backgroundImagePath)
{
	public string MainTitle { get; set; } = mainTitle;
	public string HighlightedTitlePart { get; set; } = highlightedTitlePart;
	public string DescriptionBody { get; set; } = descriptionBody;
	public string BackgroundImagePath { get; set; } = backgroundImagePath;
}
