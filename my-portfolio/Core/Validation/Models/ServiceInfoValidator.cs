using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Service;

namespace MyPortfolio.Core.Validation.Models;

public class ServiceInfoValidator : ValidatorBase<ServiceInfo>
{
	public override void ValidateModel(ServiceInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ServiceInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Name))
		{
			result.AddError($"{path}.{nameof(model.Name)} is required.");
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Description))
		{
			result.AddError($"{path}.{nameof(model.Description)} is required.");
		}

		if (!result.IsValid)
		{
			RegisterExample(result, ServiceInfo.Default);
		}
	}
}
