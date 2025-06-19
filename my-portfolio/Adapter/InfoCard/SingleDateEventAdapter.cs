using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapter.InfoCard;

public class SingleDateEventAdapter() : IInfoCardAdapter<SingleDateEvent>
{
	public InfoCardModel Adapt(SingleDateEvent source)
	{
		return new InfoCardModel
		{
			Header = source.Date.ToString(source.DateFormat.GetFormat()),
			Body = source.Description,
			Footer = source.Note
		};
	}
}
