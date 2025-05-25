namespace MyPortfolio.Models.Contact;

public class ContactInfo(string iconUrl, string title, string detail)
{
	private string _iconUrl = iconUrl ?? string.Empty;
	private string _title = title ?? string.Empty;
	private string _detail = detail ?? string.Empty;

	public string IconUrl
	{
		get => _iconUrl;
		set => _iconUrl = value ?? string.Empty;
	}

	public string Title
	{
		get => _title;
		set => _title = value ?? string.Empty;
	}

	public string Detail
	{
		get => _detail;
		set => _detail = value ?? string.Empty;
	}

	public ContactInfo() : this("images/web.svg", "Lorem ispum", "dolor sit amet") { }
}
