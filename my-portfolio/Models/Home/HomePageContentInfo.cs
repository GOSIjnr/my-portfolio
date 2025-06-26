namespace MyPortfolio.Models.Home
{
	public class HomePageContentInfo
	{
		public required string Role { get; init; }
		public required string Greeting { get; init; }
		public string? GreetingHighlighted { get; init; }
		public required string Description { get; init; }

		public static HomePageContentInfo Default => new()
		{
			Role = "Full Stack Developer",
			Greeting = "Hello I'm",
			GreetingHighlighted = "John Doe",
			Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Scelerisque consequat, faucibus et, et."
		};
	}
}
