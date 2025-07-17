using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Common;

public class ResumeSectionIntro
{
	[Required] public required string Experience { get; init; }
	[Required] public required string Education { get; init; }
	[Required] public required string Skill { get; init; }

	public static readonly ResumeSectionIntro Default = new()
	{
		Experience = string.Empty,
		Education = string.Empty,
		Skill = string.Empty,
	};
}
