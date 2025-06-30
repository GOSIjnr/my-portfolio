using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Core.Validation;
using MyPortfolio.Models.Navigation;

public class NavigationLinkValidator : ValidatorBase<NavigationLinkInfo>
{
	public override void ValidateModel(NavigationLinkInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, NavigationLinkInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.DisplayText))
			result.AddError($"{path}.DisplayText is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.RawTargetUrl))
			result.AddError($"{path}.RawTargetUrl is required.");

		if (!result.IsValid)
			RegisterExample(result, NavigationLinkInfo.Default);
	}
}
