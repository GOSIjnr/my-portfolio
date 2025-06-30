using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Core.Validation.Models;

public class ResumeHeaderInfoValidator : ValidatorBase<ResumeHeaderInfo>
{
	public override void ValidateModel(ResumeHeaderInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ResumeHeaderInfo.Default);
			return;
		}

		if (string.IsNullOrWhiteSpace(model.Title))
		{
			result.AddError($"{path}.Title is required.");
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Subtitle))
		{
			result.AddError($"{path}.Subtitle is required.");
		}

		if (!result.IsValid)
		{
			RegisterExample(result, ResumeHeaderInfo.Default);
		}
	}
}
