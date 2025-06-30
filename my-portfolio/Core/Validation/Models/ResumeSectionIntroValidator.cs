using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Common;

namespace MyPortfolio.Core.Validation.Models;

public class ResumeSectionIntroValidator : ValidatorBase<ResumeSectionIntro>
{
	public override void ValidateModel(ResumeSectionIntro model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ResumeSectionIntro.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Experience))
			result.AddError($"{path}.{nameof(model.Experience)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Education))
			result.AddError($"{path}.{nameof(model.Education)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Skill))
			result.AddError($"{path}.{nameof(model.Skill)} is required.");

		if (!result.IsValid)
			RegisterExample(result, ResumeSectionIntro.Default);
	}
}
