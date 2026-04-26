namespace MyPortfolio.Core.Utilities;

public static partial class StringExtensions
{
	public static string RemoveEmptySpaces(this string input)
	{
		if (string.IsNullOrWhiteSpace(input)) return string.Empty;

		return new string([.. input.Where(c => !char.IsWhiteSpace(c))]);
	}
}
