namespace MyPortfolio.Models.ContactForm;

public class ContactFormInfo
{
	public required string Heading { get; init; }
	public required string SubHeading { get; init; }

	public static ContactFormInfo Default => new()
	{
		Heading = "Lorem ispum",
		SubHeading = "We are here to help you."
	};
}
