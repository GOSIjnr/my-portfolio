using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapters.InfoCard;

public static class InfoCardAdapterResolver
{
	private static readonly DateEventAdapter _dateEventAdapter = new();
	private static readonly DateRangeEventAdapter _dateRangeEventAdapter = new();

	private static InfoCardViewModel AdaptInternal(InfoEventBase source)
	{
		return source switch
		{
			DateEventInfo single => _dateEventAdapter.Adapt(single),
			DateRangeEventInfo doubleEvent => _dateRangeEventAdapter.Adapt(doubleEvent),
			_ => throw new ArgumentException($"No adapter found for type {source.GetType().Name}")
		};
	}

	public static InfoCardViewModel? Adapt(InfoEventBase source)
	{
		try
		{
			return AdaptInternal(source);
		}
		catch
		{
			return null;
		}
	}

	public static List<InfoCardViewModel> AdaptList(IEnumerable<InfoEventBase> sources)
	{
		return [.. sources
			.Select(Adapt)
			.Where(model => model is not null)
			.Cast<InfoCardViewModel>()];
	}
}
