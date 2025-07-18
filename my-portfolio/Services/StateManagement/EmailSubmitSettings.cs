using MyPortfolio.Core.Enums;

namespace MyPortfolio.Services.StateManagement;

public class EmailSubmitSettings
{
	public bool IsEnabled { get; set; } = true;
	public string DisabledMessage { get; set; } = "Email submissions are temporarily disabled.";
	public ToastLevel DisabledToastLevel { get; set; } = ToastLevel.Warning;
}
