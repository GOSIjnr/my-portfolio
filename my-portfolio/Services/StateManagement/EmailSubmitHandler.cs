using MyPortfolio.Models.ContactForm;
using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.DTOs;

namespace MyPortfolio.Services.StateManagement;

public class EmailSubmitHandler(IEmailService emailService, CooldownService cooldown, HttpClient http)
{
	private readonly HttpClient _http = http;
	private readonly IEmailService _emailService = emailService;
	private readonly CooldownService _cooldown = cooldown;

	public async Task<ApiResponse<object>> SubmitAsync(ContactFormModel model, string? honeypot)
	{
		if (!string.IsNullOrEmpty(honeypot))
		{
			return ApiResponse<object>.Fail(null, "Submission blocked (possible spam).");
		}

		if (!_cooldown.IsCoolingDown)
		{
			await _cooldown.TryFetchOnceAsync(_http);
		}

		if (_cooldown.IsCoolingDown)
		{
			return ApiResponse<object>.Fail(null, $"Please wait {_cooldown.RemainingSeconds}s before trying again.");
		}

		ApiResponse<object> response = await _emailService.SendEmailAsync(model);

		if (response.Success)
		{
			_cooldown.TriggerCooldown();
		}
		else
		{
			_cooldown.TriggerCooldown(10);
		}

		return response;
	}
}
