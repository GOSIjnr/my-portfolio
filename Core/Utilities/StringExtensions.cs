using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MyPortfolio.Core.Utilities;

public static partial class StringExtensions
{
	[GeneratedRegex(@"[^a-zA-Z0-9\s]")]
	private static partial Regex MyRegex();

	public static string ToPascalCase(this string input)
	{
		if (string.IsNullOrWhiteSpace(input)) return string.Empty;

		string cleanedInput = MyRegex().Replace(input, "");

		string[] words = cleanedInput.Split([' ', '\t', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
		StringBuilder result = new();

		foreach (string word in words)
		{
			if (word.Length > 0)
			{
				result.Append(char.ToUpper(word[0], CultureInfo.InvariantCulture));

				if (word.Length > 1)
				{
					result.Append(word[1..].ToLower(CultureInfo.InvariantCulture));
				}
			}
		}

		return result.ToString();
	}

	public static string RemoveEmptySpaces(this string input)
	{
		if (string.IsNullOrWhiteSpace(input)) return string.Empty;

		return new string([.. input.Where(c => !char.IsWhiteSpace(c))]);
	}
}
