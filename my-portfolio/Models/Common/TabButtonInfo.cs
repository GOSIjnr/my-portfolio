using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class TabButtonInfo
{
	[Required] public required string Key { get; init; }
	[Required] public required string Label { get; init; }
}
