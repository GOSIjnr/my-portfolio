using MyPortfolio.Helpers;
using MyPortfolio.Helpers.Contact;

namespace MyPortfolio.Models.UI;

public class ContactInfo(string iconUrl, string title, string detail, string link, ContactType type = ContactType.Text)
{
	private string _iconUrl = iconUrl ?? string.Empty;
	private string _title = title ?? string.Empty;
	private string _detail = detail ?? string.Empty;
	private string _link = link ?? string.Empty;
	private ContactType _type = EnumValidator.ValidateOrDefault(type, ContactType.Text);

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

	public ContactType Type
	{
		get => _type;
		set => _type = EnumValidator.ValidateOrDefault(value, ContactType.Text);
	}

	public ContactInfo() : this("images/web.svg", "Lorem ispum", "dolor sit amet", string.Empty, ContactType.Text) { }
}
