using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class AboutMeInfo
{
	[Required] public required string Introduction { get; init; }
	[Required] public required Dictionary<string, string> PersonalDetails { get; init; }
}
