using System.Text;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Helpers.Navigation;

public static class NavigationUrlFormatter
{
    public static string GetFormattedSanitizedTargetUrl(string rawTargetUrl, TargetUrlFormat format = TargetUrlFormat.Plain)
    {
        string sanitizedUrl = RemoveSpecialCharactersAndWhitespaceFromUrl(rawTargetUrl);

        return format switch
        {
            TargetUrlFormat.Plain => sanitizedUrl,
            TargetUrlFormat.HashPrefix => $"#{sanitizedUrl}",
            TargetUrlFormat.SlashPrefix => $"/{sanitizedUrl}",
            _ => sanitizedUrl,
        };
    }

    private static string RemoveSpecialCharactersAndWhitespaceFromUrl(string urlToSanitize)
    {
        if (string.IsNullOrWhiteSpace(urlToSanitize)) return string.Empty;

        string trimmedStart = urlToSanitize.Trim().TrimStart('#', '/');

        StringBuilder sanitized = new(trimmedStart.Length);

        foreach (char character in trimmedStart)
        {
            if (!char.IsWhiteSpace(character)) sanitized.Append(character);
        }

        return sanitized.ToString();
    }
}
