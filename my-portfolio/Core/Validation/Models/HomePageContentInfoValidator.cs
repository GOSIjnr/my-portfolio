using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Home;

namespace MyPortfolio.Core.Validation.Models;

public class HomePageContentInfoValidator : ValidatorBase<HomePageContentInfo>
{
	public override void ValidateModel(HomePageContentInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, HomePageContentInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Role))
			result.AddError($"{path}.{nameof(model.Role)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Greeting))
			result.AddError($"{path}.{nameof(model.Greeting)} is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Description))
			result.AddError($"{path}.{nameof(model.Description)} is required.");

		if (!result.IsValid)
			RegisterExample(result, HomePageContentInfo.Default);
	}
}
