using System.ComponentModel.DataAnnotations;
using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.InfoCard;

public class DateRangeEventInfo : InfoEventBase
{
	[Required] public required DateTime StartDate { get; init; }
	[Required] public required DateTime EndDate { get; init; }
	[Required] public required string Description { get; init; }
	public string? Note { get; init; }
	[Required] public DateFormatType StartDateFormat { get; init; }
	[Required] public DateFormatType EndDateFormat { get; init; }

	public static readonly DateRangeEventInfo Default = new()
	{
		StartDate = DateTime.Now,
		EndDate = DateTime.Now,
		Description = string.Empty,
	};
}
