using MyPortfolio.Models.Common;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Contracts.Validation;

namespace MyPortfolio.Core.Validation.Models;

public class BrandInfoValidator : ValidatorBase<BrandInfo>
{
	public override void ValidateModel(BrandInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, BrandInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.BrandDisplayName))
		{
			result.AddError($"{path}.{nameof(model.BrandDisplayName)} is required.");
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.BrandHighlightedDisplayName))
		{
			result.AddWarning($"{path}.{nameof(model.BrandHighlightedDisplayName)} is missing.");
		}

		if (ValidatorHelpers.IsValidRelativeUrl(model.BrandRawTargetUrl))
		{
			result.AddWarning($"{path}.{nameof(model.BrandRawTargetUrl)} is not a valid relative URL.");
		}

		if (!result.IsValid)
		{
			RegisterExample(result, BrandInfo.Default);
		}
	}
}
