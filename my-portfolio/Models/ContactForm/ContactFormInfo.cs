using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ContactForm;

public class ContactFormInfo
{
	[Required] public required string Heading { get; init; }
	[Required] public required string SubHeading { get; init; }
}
