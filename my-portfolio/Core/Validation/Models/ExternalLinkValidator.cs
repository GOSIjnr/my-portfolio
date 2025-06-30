using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Core.Validation.Models;

public class ExternalLinkValidator : ValidatorBase<ExternalLinkInfo>
{
	public override void ValidateModel(ExternalLinkInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ExternalLinkInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.IconUrl))
		{
			result.AddWarning($"{path}.{nameof(model.IconUrl)} is missing.");
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Title))
		{
			result.AddWarning($"{path}.{nameof(model.Title)} is missing.");
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Detail))
		{
			result.AddWarning($"{path}.{nameof(model.Detail)} is missing.");
		}

		if (model.LinkUrl is null)
		{
			result.AddError($"{path}.{nameof(model.LinkUrl)} is required.");
		}

		if (!result.IsValid)
		{
			RegisterExample(result, ExternalLinkInfo.Default);
			return;
		}
	}
}
