using MyPortfolio.Core.Enum;
using MyPortfolio.Core.Utilities;

namespace MyPortfolio.Models.InfoCard;

public class DoubleDateEvent(DateTime startDate, DateTime endDate, string description, string note, DateFormatType startDateFormat = DateFormatType.MonthYear, DateFormatType endDateFormat = DateFormatType.MonthYear) : InfoEventBase
{
	private DateTime _startDate = startDate;
	private DateTime _endDate = endDate;
	private string _description = description ?? string.Empty;
	private string _note = note ?? string.Empty;
	private DateFormatType _startDateFormat = EnumValidator.ValidateOrDefault(startDateFormat, DateFormatType.MonthYear);
	private DateFormatType _endDateFormat = EnumValidator.ValidateOrDefault(endDateFormat, DateFormatType.MonthYear);

	public DateTime StartDate
	{
		get => _startDate;
		set => _startDate = value;
	}

	public DateTime EndDate
	{
		get => _endDate;
		set => _endDate = value;
	}

	public string Description
	{
		get => _description;
		set => _description = value ?? string.Empty;
	}

	public string Note
	{
		get => _note;
		set => _note = value ?? string.Empty;
	}

	public DateFormatType StartDateFormat
	{
		get => _startDateFormat;
		set => _startDateFormat = EnumValidator.ValidateOrDefault(value, DateFormatType.MonthYear);
	}

	public DateFormatType EndDateFormat
	{
		get => _endDateFormat;
		set => _endDateFormat = EnumValidator.ValidateOrDefault(value, DateFormatType.MonthYear);
	}

	public DoubleDateEvent() : this(DateTime.UtcNow, DateTime.UtcNow, "Lorem ispum dolor sit amet", "Lorem ispum") { }
}
