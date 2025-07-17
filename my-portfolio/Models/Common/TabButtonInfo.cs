using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class TabButtonInfo
{
	[Required] public required string Key { get; init; }
	[Required] public required string Label { get; init; }

	public static readonly TabButtonInfo Default = new()
	{
		Key = string.Empty,
		Label = string.Empty,
	};
}
