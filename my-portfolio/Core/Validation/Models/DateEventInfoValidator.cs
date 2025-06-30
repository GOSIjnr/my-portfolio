using MyPortfolio.Contracts.Validation;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Core.Validation.Models;

public class DateEventInfoValidator : ValidatorBase<DateEventInfo>
{
	public override void ValidateModel(DateEventInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, DateEventInfo.Default);
			return;
		}

		if (string.IsNullOrWhiteSpace(model.Description))
			result.AddError($"{path}.{nameof(model.Description)} is required.");

		if (!result.IsValid)
			RegisterExample(result, DateEventInfo.Default);
	}
}
