namespace MyPortfolio.Models.Resume;

public class ResumeHeaderInfo
{
	public required string Title { get; init; }
	public required string Subtitle { get; init; }

	public static ResumeHeaderInfo Default => new()
	{
		Title = "Lorem ipsum",
		Subtitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Scelerisque consequat, faucibus et, et."
	};
}
