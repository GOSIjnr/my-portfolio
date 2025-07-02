namespace MyPortfolio.Models.InfoCard;

public class InfoCardViewModel()
{
	public required string Header { get; init; }
	public required string Body { get; init; }
	public string? Footer { get; init; }
}
