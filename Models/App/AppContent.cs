using MyPortfolio.Services.Contracts;

namespace MyPortfolio.Models.App;

public class AppContent
{
	public required IUserProfileData User { get; init; }
	public required IAppLayoutData Layout { get; init; }
}
