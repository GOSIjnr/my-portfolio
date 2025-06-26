using MyPortfolio.Contracts.Validation;
using MyPortfolio.Contracts.Layout;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Services.Validation;

public class LayoutDataValidator : IValidator<IAppLayoutData>
{
	public void Validate(IAppLayoutData obj)
	{
		if (obj.NavigationLinks == null || obj.NavigationLinks.Count == 0)
			throw new ValidationException("At least one navigation link is required.");

		if (string.IsNullOrWhiteSpace(obj.ExperienceSectionBody))
			throw new ValidationException("Experience section must have content.");
	}
}
