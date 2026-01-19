using MyPortfolio.Models.ContactForm;
using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.DTOs;
using MyPortfolio.Core.Enums;
using Microsoft.Extensions.Options;

namespace MyPortfolio.Services.StateManagement;

public class EmailSubmitHandler(IEmailService emailService, CooldownService cooldown, HttpClient http, IOptions<EmailSubmitSettings>? options)
{
	private readonly HttpClient _http = http;
	private readonly IEmailService _emailService = emailService;
	private readonly CooldownService _cooldown = cooldown;
	private readonly EmailSubmitSettings? _settings = options?.Value;

	public async Task<EmailSubmissionResponse<object>> SubmitAsync(ContactFormModel model, string? honeypot)
	{
		if (_settings is { IsEnabled: false })
			return FailWithCooldown(_settings.DisabledMessage, _settings.DisabledToastLevel);

		if (!string.IsNullOrEmpty(honeypot))
			return FailWithCooldown("Submission blocked (possible spam).", ToastLevel.Info);

		if (!_cooldown.IsCoolingDown)
			await _cooldown.TryFetchOnceAsync(_http);

		if (_cooldown.IsCoolingDown)
			return Fail("Please wait " + _cooldown.RemainingSeconds + "s before trying again.", ToastLevel.Warning);

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

		return FailWithCooldown(response.Message ?? "Failed to send email.", ToastLevel.Danger, response);
	}

	private EmailSubmissionResponse<object> FailWithCooldown(string message, ToastLevel level, ApiResponse<object>? customResponse = null)
	{
		_cooldown.TriggerCooldown(10);
		return new EmailSubmissionResponse<object>
		{
			Response = customResponse ?? ApiResponse<object>.Fail(null, message),
			ToastLevel = level,
		};
	}

	private static EmailSubmissionResponse<object> Fail(string message, ToastLevel level)
	{
		return new EmailSubmissionResponse<object>
		{
			Response = ApiResponse<object>.Fail(null, message),
			ToastLevel = level,
		};
	}
}
