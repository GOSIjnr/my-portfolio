using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Project;

namespace MyPortfolio.Core.Validation.Models;

public class ProjectInfoValidator : ValidatorBase<ProjectInfo>
{
	public override void ValidateModel(ProjectInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ProjectInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Title))
			result.AddError($"{path}.{nameof(model.Title)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Description))
			result.AddWarning($"{path}.{nameof(model.Description)} is missing.");

		if (model.LiveLink is not null)
			ExternalLinkValidator.Validate(model.LiveLink, result, $"{path}.LiveLink");

		if (model.OtherLinks is not null)
		{
			for (int i = 0; i < model.OtherLinks.Count; i++)
				ExternalLinkValidator.Validate(model.OtherLinks[i], result, $"{path}.OtherLinks[{i}]");
		}

		if (!result.IsValid)
			RegisterExample(result, ProjectInfo.Default);
	}
}
