using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.DTOs;

namespace MyPortfolio.Contracts.ContactForm;

public interface IEmailService
{
	Task<ApiResponse<object>> SendEmailAsync(ContactFormModel model);
}
