namespace MyPortfolio.Models.Common;

public class SkillInfo
{
	public required string Name { get; init; }
	public required string IconUrl { get; init; }

	public static SkillInfo Default => new()
	{
		Name = "Lorem ispum",
		IconUrl = "images/web.svg"
	};
}
