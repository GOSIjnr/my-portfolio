namespace MyPortfolio.Models.Navigation;

public class NavLinkItemData(string text, string href, string cssClass)
{
	public string Text { get; set; } = text;
	public string Href { get; set; } = href;
	public string CssClass { get; set; } = cssClass;
}
