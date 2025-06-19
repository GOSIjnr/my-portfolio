namespace MyPortfolio.Models.Resume;

public class ResumeHeaderLayoutData(string title, string subtitle)
{
	private string _title = title ?? string.Empty;
	private string _subtitle = subtitle ?? string.Empty;

	public string Title
	{
		get => _title;
		set => _title = value ?? string.Empty;
	}

	public string Subtitle
	{
		get => _subtitle;
		set => _subtitle = value ?? string.Empty;
	}

	public ResumeHeaderLayoutData() : this("Lorem Ispum", "Lorem ispum dolor sit amet, consectetur adipiscing elit.") { }
}
