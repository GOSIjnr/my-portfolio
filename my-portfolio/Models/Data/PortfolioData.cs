using MyPortfolio.Contracts.Layout;
using MyPortfolio.Contracts.Profile;

namespace MyPortfolio.Models.Data;

public class PortfolioData
{
	public required IUserProfileData User { get; init; }
	public required IAppLayoutData Layout { get; init; }
}
