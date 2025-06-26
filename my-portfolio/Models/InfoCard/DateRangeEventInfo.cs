using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.InfoCard;

public class DateRangeEventInfo : InfoEventBase
{
	public required DateTime StartDate { get; init; }
	public required DateTime EndDate { get; init; }
	public required string Description { get; init; }
	public string? Note { get; init; }
	public DateFormatType StartDateFormat { get; init; }
	public DateFormatType EndDateFormat { get; init; }

	public static DateRangeEventInfo Default => new()
	{
		StartDate = DateTime.UtcNow,
		EndDate = DateTime.UtcNow,
		Description = "Lorem ispum dolor sit amet",
		Note = "Lorem ispum",
		StartDateFormat = DateFormatType.MonthYear,
		EndDateFormat = DateFormatType.MonthYear
	};
}
