using MyPortfolio.Contracts.Validation;
using MyPortfolio.Models.Data;

namespace MyPortfolio.Core.Validation.Models;

public class UserProfileDataValidator : ValidatorBase<UserProfileData>
{
	public override void ValidateModel(UserProfileData model, ValidationResult result, string path)
	{
		BrandInfoValidator.Validate(model.Brand, result, $"{path}.Brand");

		for (int i = 0; i < model.SocialLinks.Count; i++)
		{
			ExternalLinkValidator.Validate(model.SocialLinks[i], result, $"{path}.SocialLinks[{i}]");
		}
	}
}
