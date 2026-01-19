using System.ComponentModel.DataAnnotations;
using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.InfoCard;

public class DateRangeEventInfo : InfoEventBase
{
	[Required] public required DateOnly StartDate { get; init; }
	[Required] public required DateOnly EndDate { get; init; }
	[Required] public required string Description { get; init; }
	public string? Note { get; init; }
	[Required] public DateFormatType StartDateFormat { get; init; }
	[Required] public DateFormatType EndDateFormat { get; init; }

	public static readonly DateRangeEventInfo Default = new()
	{
		StartDate = DateOnly.MinValue,
		EndDate = DateOnly.MaxValue,
		Description = string.Empty,
	};
}
