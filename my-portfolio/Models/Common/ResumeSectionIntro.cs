namespace MyPortfolio.Models.Common;

public class ResumeSectionIntro
{
	public required string Experience { get; init; }
	public required string Education { get; init; }
	public required string Skill { get; init; }

	private static readonly string _loremIpsum = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat voluptatum voluptas praesentium, odit reiciendis, doloremque magni aspernatur sequi inventore excepturi laudantium cupiditate tenetur id maxime at, iusto deleniti a illo.";

	public static ResumeSectionIntro Default => new()
	{
		Experience = _loremIpsum,
		Education = _loremIpsum,
		Skill = _loremIpsum
	};
}
