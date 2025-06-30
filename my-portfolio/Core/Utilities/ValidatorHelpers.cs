namespace MyPortfolio.Core.Utilities;

public static class ValidatorHelpers
{
	public static bool IsNullOrWhiteSpace(string? input) => string.IsNullOrWhiteSpace(input);

	public static bool IsRelativeUrl(string? url)
	{
		if (url is null) return false;

		if (url == string.Empty) return true;

		return Uri.TryCreate(url, UriKind.Relative, out _);
	}
}
