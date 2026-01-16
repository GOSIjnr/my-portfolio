using FuzzySharp;
using MyPortfolio.Contracts.Filtering;

namespace MyPortfolio.Core.Utilities;

public class FuzzySearchFilter(int threshold = 60) : ISearchFilter
{
	private readonly int _threshold = threshold;

	public IEnumerable<string> Filter(IEnumerable<string> services, string? query)
	{
		if (string.IsNullOrWhiteSpace(query)) return services;

		string cleanedQuery = query.ToLower().RemoveEmptySpaces();

		return services
			.Select(s => new
			{
				Name = s,
				Score = Fuzz.PartialRatio(cleanedQuery, s.ToLower().RemoveEmptySpaces())
			})
			.Where(x => x.Score > _threshold)
			.OrderByDescending(x => x.Score)
			.Select(x => x.Name);
	}
}
