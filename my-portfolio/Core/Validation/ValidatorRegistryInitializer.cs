using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Validation.Models;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Core.Validation;

public static class ValidatorRegistryInitializer
{
	private static bool _initialized;

	public static void RegisterAll()
	{
		if (_initialized) return;
		_initialized = true;

		ValidatorBase<UserProfileData>.RegisterValidator(new UserProfileDataValidator());
		// ValidatorBase<AppLayoutData>.RegisterValidator(new AppLayoutDataValidator());

		ValidatorBase<BrandInfo>.RegisterValidator(new BrandInfoValidator());
		ValidatorBase<ExternalLinkInfo>.RegisterValidator(new ExternalLinkValidator());
	}
}

