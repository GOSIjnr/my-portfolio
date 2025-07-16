using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ContactForm;

public class ContactFormModel
{
	[Required(ErrorMessage = "Please enter your first name.")]
	[StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
	public string? FirstName { get; set; }

	[Required(ErrorMessage = "Please enter your last name.")]
	[StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
	public string? LastName { get; set; }

	[Required(ErrorMessage = "Please enter your email address.")]
	[EmailAddress(ErrorMessage = "That doesn't look like a valid email address.")]
	[StringLength(200, MinimumLength = 2, ErrorMessage = "Email address must be between 2 and 200 characters.")]
	public string? Email { get; set; }

	[Required(ErrorMessage = "Please select a service.")]
	public string? Service { get; set; }

	[Required(ErrorMessage = "Please tell us the reason you're reaching out.")]
	[StringLength(100, MinimumLength = 2, ErrorMessage = "Reason must be between 2 and 100 characters.")]
	public string? Reason { get; set; }

	[StringLength(2000, ErrorMessage = "Your message is too long. Please keep it under 2000 characters.")]
	public string? Message { get; set; }
}
