using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapters.InfoCard;

public class DateRangeEventAdapter() : IInfoCardAdapter<DateRangeEventInfo>
{
	public InfoCardViewModel Adapt(DateRangeEventInfo source)
	{
		string formattedStart = source.StartDate.ToString(source.StartDateFormat.GetFormat());
		string formattedEnd = source.EndDate.ToString(source.EndDateFormat.GetFormat());

		return new InfoCardViewModel()
		{
			Header = $"{formattedStart} - {formattedEnd}",
			Body = source.Description,
			Footer = source.Note
		};
	}
}
