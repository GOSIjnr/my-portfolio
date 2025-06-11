using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapter.InfoCard;

public class DoubleDateEventAdapter() : IInfoCardAdapter<DoubleDateEvent>
{
	public InfoCardModel Adapt(DoubleDateEvent source)
	{
		string formattedStart = source.StartDate.ToString(source.StartDateFormat.GetFormat());
		string formattedEnd = source.EndDate.ToString(source.EndDateFormat.GetFormat());

		return new InfoCardModel
		{
			Header = $"{formattedStart} - {formattedEnd}",
			Body = source.Description,
			Footer = source.Note,
		};
	}
}
