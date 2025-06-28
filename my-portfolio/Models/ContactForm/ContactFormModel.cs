using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ContactForm;

public class ContactFormModel
{
	[Required, StringLength(50, MinimumLength = 2)]
	public string? FirstName { get; set; }

	[Required, StringLength(50, MinimumLength = 2)]
	public string? LastName { get; set; }

	[Required, EmailAddress, StringLength(200, MinimumLength = 2)]
	public string? Email { get; set; }

	[Required] public string? Service { get; set; }

	[Required, StringLength(100, MinimumLength = 2)]
	public string? Reason { get; set; }

	[StringLength(2000)] public string? Message { get; set; }
}
