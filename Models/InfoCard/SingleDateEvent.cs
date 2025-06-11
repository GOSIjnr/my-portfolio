using MyPortfolio.Core.Enum;
using MyPortfolio.Core.Utilities;

namespace MyPortfolio.Models.InfoCard;

public class SingleDateEvent(DateTime date, string description, string note, DateFormatType dateFormat = DateFormatType.MonthYear) : InfoEventBase
{
	private DateTime _date = date;
	private string _description = description ?? string.Empty;
	private string _note = note ?? string.Empty;
	private DateFormatType _dateFormat = EnumValidator.ValidateOrDefault(dateFormat, DateFormatType.MonthYear);

	public DateTime Date
	{
		get => _date;
		set => _date = value;
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

	public DateFormatType DateFormat
	{
		get => _dateFormat;
		set => _dateFormat = EnumValidator.ValidateOrDefault(value, DateFormatType.MonthYear);
	}

	public SingleDateEvent() : this(DateTime.UtcNow, "Lorem ispum dolor sit amet", "Lorem ispum", DateFormatType.MonthYear) { }
}
