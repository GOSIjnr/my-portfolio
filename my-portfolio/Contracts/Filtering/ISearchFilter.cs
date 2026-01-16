namespace MyPortfolio.Contracts.Filtering;

public interface ISearchFilter
{
	IEnumerable<string> Filter(IEnumerable<string> services, string? query);
}
