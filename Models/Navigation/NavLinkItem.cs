using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Navigation;

public class NavLinkItem
{
	[Required] public required string Href { get; set; }
	[Required] public required string Text { get; set; }
	[Required] public required string CssClass { get; set; }
}
