using System.Net.Http.Json;
using System.Text.Json;
using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.DTOs;
using MyPortfolio.Services.Config;

namespace MyPortfolio.Services.StateManagement;

public class EmailService(HttpClient http) : IEmailService
{
	private readonly HttpClient _http = http;
	private readonly JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true };

	public async Task<ApiResponse<object>> SendEmailAsync(ContactFormModel model)
	{
		try
		{
			HttpResponseMessage response = await _http.PostAsJsonAsync(ApiRoutes.Email.Send, model);

			string json = await response.Content.ReadAsStringAsync();
			var parsed = JsonSerializer.Deserialize<ApiResponse<object>>(json, _options);

			if (parsed is null)
			{
				return ApiResponse<object>.Fail(null, "Invalid server response.");
			}

			return parsed;
		}
		catch (Exception ex)
		{
			return ApiResponse<object>.Fail(null, ex.Message);
		}
	}
}
