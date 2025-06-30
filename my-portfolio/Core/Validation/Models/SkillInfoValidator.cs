using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Common;

namespace MyPortfolio.Core.Validation.Models;

public class SkillInfoValidator : ValidatorBase<SkillInfo>
{
	public override void ValidateModel(SkillInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, SkillInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Name))
			result.AddError($"{path}.{nameof(model.Name)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.IconUrl))
			result.AddError($"{path}.{nameof(model.IconUrl)} is required.");

		if (!result.IsValid)
			RegisterExample(result, SkillInfo.Default);
	}
}
