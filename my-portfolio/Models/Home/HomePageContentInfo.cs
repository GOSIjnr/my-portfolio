namespace MyPortfolio.Models.Home;

public class HomePageContentInfo(string role, string greeting, string greetingHighlighted, string description)
{
	private string _role = role ?? string.Empty;
	private string _greeting = greeting ?? string.Empty;
	private string _greetingHighlighted = greetingHighlighted ?? string.Empty;
	private string _description = description ?? string.Empty;

	public string Role
	{
		get => _role;
		set => _role = value ?? string.Empty;
	}

	public string Greeting
	{
		get => _greeting;
		set => _greeting = value ?? string.Empty;
	}

	public string GreetingHighlighted
	{
		get => _greetingHighlighted;
		set => _greetingHighlighted = value ?? string.Empty;
	}

	public string Description
	{
		get => _description;
		set => _description = value ?? string.Empty;
	}

	public HomePageContentInfo() : this("Lorem ispum", "Hello I'm", "Lorem ispum", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Scelerisque consequat, faucibus et, et.") {}
}
