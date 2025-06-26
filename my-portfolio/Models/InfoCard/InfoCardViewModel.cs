namespace MyPortfolio.Models.InfoCard;

public class InfoCardViewModel()
{
	public required string Header { get; init; }
	public required string Body { get; init; }
	public string? Footer { get; init; }

	public static InfoCardViewModel Default => new()
	{
		Header = "1999 - Present",
		Body = "Lorem ispum dolor sit amet",
		Footer = "Lorem ispum"
	};
}
