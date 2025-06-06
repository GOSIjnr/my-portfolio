using System.Text;
using System.Globalization;

namespace MyPortfolio.Helpers.Utilities;

public static class StringExtensions
{
	public static string ToPascalCase(this string input)
	{
		if (string.IsNullOrWhiteSpace(input)) return string.Empty;

		string[] words = input.Split([' ', '\t', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
		StringBuilder result = new();

		foreach (string word in words)
		{
			string trimmed = word.Trim();

			if (trimmed.Length > 0)
			{
				result.Append(char.ToUpper(trimmed[0], CultureInfo.InvariantCulture));

				if (trimmed.Length > 1)
				{
					result.Append(trimmed[1..].ToLower(CultureInfo.InvariantCulture));
				}
			}
		}

		return result.ToString();
	}
}
