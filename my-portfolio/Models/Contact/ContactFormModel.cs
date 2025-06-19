using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Contact;

public class ContactFormModel
{
	[Required, StringLength(50, MinimumLength = 2)] public string? FirstName { get; set; }
	[Required, StringLength(50, MinimumLength = 2)] public string? LastName { get; set; }
	[Required, EmailAddress, StringLength(100)] public string? Email { get; set; }
	[Required, Phone, StringLength(20, MinimumLength = 7)] public string? Phone { get; set; }
	[Required] public string? Service { get; set; }
	[StringLength(1000)] public string? Message { get; set; }
}
