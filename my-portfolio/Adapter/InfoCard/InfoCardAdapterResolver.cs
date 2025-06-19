using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Adapter.InfoCard;

public static class InfoCardAdapterResolver
{
	private static readonly SingleDateEventAdapter _singleAdapter = new();
	private static readonly DoubleDateEventAdapter _doubleAdapter = new();

	private static InfoCardModel AdaptInternal(InfoEventBase source)
	{
		return source switch
		{
			SingleDateEvent single => _singleAdapter.Adapt(single),
			DoubleDateEvent doubleEvent => _doubleAdapter.Adapt(doubleEvent),
			_ => throw new ArgumentException($"No adapter found for type {source.GetType().Name}")
		};
	}

	public static InfoCardModel? Adapt(InfoEventBase source)
	{
		try
		{
			return AdaptInternal(source);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine($"[Warning] Adapt skipped unknown type: {ex.Message}");
			return null;
		}
	}

	public static List<InfoCardModel> AdaptList(IEnumerable<InfoEventBase> sources)
	{
		return [.. sources.Select(Adapt).Where(model => model is not null)];
	}
}
