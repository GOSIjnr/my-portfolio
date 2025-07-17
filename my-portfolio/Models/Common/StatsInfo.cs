using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class StatInfo
{
	[Required] public required double Number { get; init; }
	public string? NumberPrefix { get; init; }
	[Required] public required string LabelLine1 { get; init; }
	public string? LabelLine2 { get; init; }

	public static readonly StatInfo Default = new()
	{
		Number = 0,
		LabelLine1 = string.Empty,
	};
}
