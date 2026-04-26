using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapters.InfoCard;

public class DateEventAdapter() : IInfoCardAdapter<DateEventInfo>
{
	public InfoCardViewModel Adapt(DateEventInfo source)
	{
		string formattedDate = source.Date.ToString(source.DateFormat.GetFormat());

		return new InfoCardViewModel()
		{
			Header = formattedDate,
			Body = source.Description,
			Footer = source.Note
		};
	}
}
