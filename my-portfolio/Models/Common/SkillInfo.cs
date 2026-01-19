using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class SkillInfo
{
	[Required] public required string Name { get; init; }
	[Required] public required string IconUrl { get; init; }

	public static SkillInfo Default => new()
	{
		Name = string.Empty,
		IconUrl = string.Empty,
	};
}
