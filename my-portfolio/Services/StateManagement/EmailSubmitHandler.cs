using MyPortfolio.Models.ContactForm;
using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.DTOs;
using MyPortfolio.Core.Enums;

namespace MyPortfolio.Services.StateManagement;

public class EmailSubmitHandler(IEmailService emailService, CooldownService cooldown, HttpClient http)
{
	private readonly HttpClient _http = http;
	private readonly IEmailService _emailService = emailService;
	private readonly CooldownService _cooldown = cooldown;

	public async Task<EmailSubmissionResponse<object>> SubmitAsync(ContactFormModel model, string? honeypot)
	{
		if (!string.IsNullOrEmpty(honeypot))
		{
			return new EmailSubmissionResponse<object>
			{
				Response = ApiResponse<object>.Fail(null, "Submission blocked (possible spam)."),
				ToastLevel = ToastLevel.Info,
			};
		}

		if (!_cooldown.IsCoolingDown)
		{
			await _cooldown.TryFetchOnceAsync(_http);
		}

		if (_cooldown.IsCoolingDown)
		{
			return new EmailSubmissionResponse<object>
			{
				Response = ApiResponse<object>.Fail(null, $"Please wait {_cooldown.RemainingSeconds}s before trying again."),
				ToastLevel = ToastLevel.Warning,
			};
		}

		ApiResponse<object> response = await _emailService.SendEmailAsync(model);

		if (response.Success)
		{
			_cooldown.TriggerCooldown();
			return new EmailSubmissionResponse<object>
			{
				Response = response,
				ToastLevel = ToastLevel.Success,
			};
		}

		_cooldown.TriggerCooldown(10);

		return new EmailSubmissionResponse<object>
		{
			Response = response,
			ToastLevel = ToastLevel.Danger,
		};
	}
}
