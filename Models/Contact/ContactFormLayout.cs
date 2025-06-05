namespace MyPortfolio.Models.Contact;

public class ContactFormLayout(string heading, string subHeading)
{
	private string _heading = heading ?? string.Empty;
	private string _subHeading = subHeading ?? string.Empty;

	public string Heading
	{
		get => _heading;
		set => _heading = value ?? string.Empty;
	}

	public string SubHeading
	{
		get => _subHeading;
		set => _subHeading = value ?? string.Empty;
	}

	public ContactFormLayout() : this("Lorem ispum", "dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.") { }
}
