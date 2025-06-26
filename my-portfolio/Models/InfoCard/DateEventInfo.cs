using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.InfoCard;

public class DateEventInfo : InfoEventBase
{
	public required DateTime Date { get; init; }
	public required string Description { get; init; }
	public string? Note { get; init; }
	public DateFormatType DateFormat { get; init; }

	public static DateEventInfo Default => new()
	{
		Date = DateTime.UtcNow,
		Description = "Lorem ispum dolor sit amet",
		Note = "Lorem ispum",
		DateFormat = DateFormatType.MonthYear
	};
}
