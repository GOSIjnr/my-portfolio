using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapter.InfoCard;

public interface IInfoCardAdapter<T> where T : InfoEventBase
{
	InfoCardModel Adapt(T source);
}
