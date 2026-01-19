using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Resume;

public class ResumeHeaderInfo
{
	[Required] public required string Title { get; init; }
	[Required] public required string Subtitle { get; init; }

	public static readonly ResumeHeaderInfo Default = new()
	{
		Title = string.Empty,
		Subtitle = string.Empty,
	};
}
