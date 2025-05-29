using MyPortfolio.Helpers.Utilities;
using MyPortfolio.Helpers.Navigation;

namespace MyPortfolio.Models.Navigation;

public class LinkInfo(string iconUrl, string title, string detail, string link, LinkType type = LinkType.Text)
{
	private string _iconUrl = iconUrl ?? string.Empty;
	private string _title = title ?? string.Empty;
	private string _detail = detail ?? string.Empty;
	private string _link = link ?? string.Empty;
	private LinkType _type = EnumValidator.ValidateOrDefault(type, LinkType.Text);

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

	public string Link
	{
		get => _link;
		set => _link = value ?? string.Empty;
	}

	public LinkType Type
	{
		get => _type;
		set => _type = EnumValidator.ValidateOrDefault(value, LinkType.Text);
	}

	public LinkInfo() : this("images/web.svg", "Lorem ispum", "dolor sit amet", string.Empty, LinkType.Text) { }
}
