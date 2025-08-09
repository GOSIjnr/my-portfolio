using MyPortfolio.Core.Enums;

namespace MyPortfolio.Core.Utilities;

public static class DateFormatHelper
{
	public static string GetFormat(this DateFormatType formatType)
	{
		return formatType switch
		{
			DateFormatType.MonthYear => "MMMM yyyy",
			DateFormatType.YearMonth => "yyyy MMMM",
			DateFormatType.DayMonthYear => "dd MMM yyyy",
			DateFormatType.IsoDate => "yyyy-MM-dd",
			DateFormatType.FullDateTime => "dddd, dd MMMM yyyy",
			_ => "yyyy-MM-dd"
		};
	}
}
