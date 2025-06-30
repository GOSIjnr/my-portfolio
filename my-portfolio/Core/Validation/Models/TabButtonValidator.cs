using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Core.Validation;
using MyPortfolio.Models.Common;

public class TabButtonValidator : ValidatorBase<TabButtonInfo>
{
	public override void ValidateModel(TabButtonInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, TabButtonInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Key))
			result.AddError($"{path}.Key is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Label))
			result.AddError($"{path}.Label is required.");

		if (!result.IsValid)
			RegisterExample(result, TabButtonInfo.Default);
	}
}
