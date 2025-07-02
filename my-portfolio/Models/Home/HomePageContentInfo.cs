using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Home;

public class HomePageContentInfo
{
	[Required] public required string Role { get; init; }
	[Required] public required string Greeting { get; init; }
	public string? GreetingHighlighted { get; init; }
	[Required] public required string Description { get; init; }
}
