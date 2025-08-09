using System.ComponentModel.DataAnnotations;
using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.InfoCard;

public class DateEventInfo : InfoEventBase
{
	[Required] public required DateOnly Date { get; init; }
	[Required] public required string Description { get; init; }
	public string? Note { get; init; }
	[Required] public DateFormatType DateFormat { get; init; }

	public static readonly DateEventInfo Default = new()
	{
		Date = DateOnly.MaxValue,
		Description = string.Empty,
	};
}
