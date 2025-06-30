using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Common;

namespace MyPortfolio.Core.Validation.Models;

public class AboutMeInfoValidator : ValidatorBase<AboutMeInfo>
{
	public override void ValidateModel(AboutMeInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, AboutMeInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Introduction))
			result.AddError($"{path}.{nameof(model.Introduction)} is required.");

		if (model.PersonalDetails is null || model.PersonalDetails.Count == 0)
			result.AddWarning($"{path}.{nameof(model.PersonalDetails)} is empty.");

		if (!result.IsValid)
			RegisterExample(result, AboutMeInfo.Default);
	}
}
