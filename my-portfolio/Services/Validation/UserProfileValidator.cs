using MyPortfolio.Contracts.Validation;
using MyPortfolio.Contracts.Profile;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Services.Validation;

public class UserProfileValidator : IValidator<IUserProfileData>
{
	public void Validate(IUserProfileData obj)
	{
		if (string.IsNullOrWhiteSpace(obj.Brand?.BrandDisplayName))
			throw new ValidationException("User brand display name is required.");

		if (obj.SocialLinks is null || obj.SocialLinks.Count == 0)
			throw new ValidationException("At least one social link is required.");

		if (obj.ContactLinks is null || obj.ContactLinks.Count == 0)
			throw new ValidationException("At least one contact info is required.");
	}
}
