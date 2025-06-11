namespace MyPortfolio.Models.InfoCard;

public class InfoCardModel(string header, string body, string footer)
{
	private string _header = header ?? string.Empty;
	private string _body = body ?? string.Empty;
	private string _footer = footer ?? string.Empty;

	public string Header
	{
		get => _header;
		set => _header = value ?? string.Empty;
	}

	public string Body
	{
		get => _body;
		set => _body = value ?? string.Empty;
	}

	public string Footer
	{
		get => _footer;
		set => _footer = value ?? string.Empty;
	}

	public InfoCardModel() : this("1999 - present", "Lorem ispum dolor sit amet", "Lorem ipsum") { }
}
