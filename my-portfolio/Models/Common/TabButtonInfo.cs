namespace MyPortfolio.Models.Common;

public class TabButtonInfo
{
	public required string Key { get; init; }
	public required string Label { get; init; }

	public static TabButtonInfo Default => new()
	{
		Key = "LoremIspum",
		Label = "Lorem ispum"
	};
}
