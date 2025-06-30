using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Core.Validation;
using MyPortfolio.Models.ContactForm;

public class ContactFormValidator : ValidatorBase<ContactFormInfo>
{
	public override void ValidateModel(ContactFormInfo model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, ContactFormInfo.Default);
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.Heading))
			result.AddError($"{path}.Heading is required.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(model.SubHeading))
			result.AddError($"{path}.SubHeading is required.");

		if (!result.IsValid)
			RegisterExample(result, ContactFormInfo.Default);
	}
}
