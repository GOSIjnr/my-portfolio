using MyPortfolio.Core.Enums;

namespace MyPortfolio.Services.StateManagement;

public class EmailSubmitSettings
{
	public bool IsEnabled { get; set; } = true;
	public string DisabledMessage { get; set; } = "Email submissions are currently unavailable. Please use an alternative contact method.";
	public ToastLevel DisabledToastLevel { get; set; } = ToastLevel.Warning;
}
