using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class AboutMeInfo
{
	[Required] public required string Introduction { get; init; }
	public Dictionary<string, string>? PersonalDetails { get; init; }

	public readonly static AboutMeInfo Default = new()
	{
		Introduction = string.Empty,
	};
}
