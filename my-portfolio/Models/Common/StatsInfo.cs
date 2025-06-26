namespace MyPortfolio.Models.Common;

public class StatInfo
{
	public required double Number { get; init; }
	public string? NumberPrefix { get; init; }
	public required string Description { get; init; }

	public static StatInfo Default => new()
	{
		Number = 0,
		NumberPrefix = string.Empty,
		Description = "No data<br>available"
	};
}
