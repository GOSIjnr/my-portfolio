using MyPortfolio.Contracts.Validation;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Resume;

namespace MyPortfolio.Core.Validation.Models;

public class AppLayoutDataValidator : ValidatorBase<AppLayoutData>
{
	public override void ValidateModel(AppLayoutData model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, new AppLayoutData
			{
				NavigationLinks = [NavigationLinkInfo.Default],
				ContactMeLink = NavigationLinkInfo.Default,
				DownloadCVLink = NavigationLinkInfo.Default,
				ProjectsLink = NavigationLinkInfo.Default,
				ContactForm = ContactFormInfo.Default,
				ResumeHeader = ResumeHeaderInfo.Default,
				ResumeTabs = [TabButtonInfo.Default]
			});
			return;
		}

		if (model.NavigationLinks is null || model.NavigationLinks.Count == 0)
		{
			result.AddError($"{path}.NavigationLinks is required and cannot be empty.");
		}
		else
		{
			for (int i = 0; i < model.NavigationLinks.Count; i++)
			{
				NavigationLinkValidator.Validate(model.NavigationLinks[i], result, $"{path}.NavigationLinks[{i}]");
			}
		}

		NavigationLinkValidator.Validate(model.ContactMeLink, result, $"{path}.ContactMeLink");
		NavigationLinkValidator.Validate(model.DownloadCVLink, result, $"{path}.DownloadCVLink");
		NavigationLinkValidator.Validate(model.ProjectsLink, result, $"{path}.ProjectsLink");

		ContactFormValidator.Validate(model.ContactForm, result, $"{path}.ContactForm");
		ResumeHeaderInfoValidator.Validate(model.ResumeHeader, result, $"{path}.ResumeHeader");

		if (model.ResumeTabs is null || model.ResumeTabs.Count == 0)
		{
			result.AddError($"{path}.ResumeTabs must contain at least one tab.");
		}
		else
		{
			for (int i = 0; i < model.ResumeTabs.Count; i++)
			{
				TabButtonValidator.Validate(model.ResumeTabs[i], result, $"{path}.ResumeTabs[{i}]");
			}
		}

		if (!result.IsValid)
		{
			RegisterExample(result, new AppLayoutData
			{
				NavigationLinks = [NavigationLinkInfo.Default],
				ContactMeLink = NavigationLinkInfo.Default,
				DownloadCVLink = NavigationLinkInfo.Default,
				ProjectsLink = NavigationLinkInfo.Default,
				ContactForm = ContactFormInfo.Default,
				ResumeHeader = ResumeHeaderInfo.Default,
				ResumeTabs = [TabButtonInfo.Default]
			});
		}
	}
}
