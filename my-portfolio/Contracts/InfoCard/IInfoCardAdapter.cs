using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Contracts.InfoCard;

public interface IInfoCardAdapter<T> where T : InfoEventBase
{
	InfoCardViewModel Adapt(T source);
}
