namespace MyPortfolio.Models.InfoCard;

public class InfoCardViewModel()
{
	public required string Header { get; init; }
	public required string Body { get; init; }
	public string? Footer { get; init; }

	public static readonly InfoCardViewModel Default = new()
	{
		Header = string.Empty,
		Body = string.Empty,
	};
}
