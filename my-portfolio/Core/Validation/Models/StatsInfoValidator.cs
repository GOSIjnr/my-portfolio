using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Common;

namespace MyPortfolio.Core.Validation.Models;

public class StatInfoValidator : ValidatorBase<StatInfo>
{
	public override void ValidateModel(StatInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, StatInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Description))
			result.AddError($"{path}.{nameof(model.Description)} is required.");

		if (!result.IsValid)
			RegisterExample(result, StatInfo.Default);
	}
}
