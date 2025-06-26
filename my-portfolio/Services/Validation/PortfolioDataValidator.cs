using MyPortfolio.Contracts.Layout;
using MyPortfolio.Contracts.Profile;
using MyPortfolio.Contracts.Validation;
using MyPortfolio.Models.Data;

namespace MyPortfolio.Services.Validation;

public class PortfolioDataValidator(
	IValidator<IUserProfileData> userValidator,
	IValidator<IAppLayoutData> layoutValidator) : IValidator<PortfolioData>
{
	private readonly IValidator<IUserProfileData> _userValidator = userValidator;
	private readonly IValidator<IAppLayoutData> _layoutValidator = layoutValidator;

	public void Validate(PortfolioData obj)
	{
		_userValidator.Validate(obj.User);
		_layoutValidator.Validate(obj.Layout);
	}
}
