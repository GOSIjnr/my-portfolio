using MyPortfolio.Contracts;

namespace MyPortfolio.Models.Profile;

public class AppContent
{
	public required IUserProfileData User { get; init; }
	public required IAppLayoutData Layout { get; init; }
}
