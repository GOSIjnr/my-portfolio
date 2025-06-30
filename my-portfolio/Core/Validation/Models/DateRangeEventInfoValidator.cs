using MyPortfolio.Contracts.Validation;
using MyPortfolio.Models.InfoCard;

namespace MyPortfolio.Core.Validation.Models;

public class DateRangeEventInfoValidator : ValidatorBase<DateRangeEventInfo>
{
	public override void ValidateModel(DateRangeEventInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, DateRangeEventInfo.Default);
			return;
		}

		if (string.IsNullOrWhiteSpace(model.Description))
			result.AddError($"{path}.{nameof(model.Description)} is required.");

		if (model.EndDate < model.StartDate)
			result.AddWarning($"{path}: EndDate is earlier than StartDate.");

		if (!result.IsValid)
			RegisterExample(result, DateRangeEventInfo.Default);
	}
}
