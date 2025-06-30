using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Utilities;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.InfoCard;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Service;

namespace MyPortfolio.Core.Validation.Models;

public class UserProfileDataValidator : ValidatorBase<UserProfileData>
{
	public override void ValidateModel(UserProfileData model, ValidationResult result, string path)
	{
		if (model is null)
		{
			result.AddError($"{path} is null.");
			RegisterExample(result, new UserProfileData
			{
				Brand = BrandInfo.Default,
				ProfileImageUrl = "https://example.com/images/profile.jpg",
				SocialLinks = [ExternalLinkInfo.Default],
				Services = [ServiceInfo.Default],
				ContactLinks = [ExternalLinkInfo.Default],
				Projects = [ProjectInfo.Default],
				AboutMeInfo = AboutMeInfo.Default,
				ExperienceEvents = [DateEventInfo.Default, DateRangeEventInfo.Default],
				EducationEvents = [DateEventInfo.Default, DateRangeEventInfo.Default],
				Skills = [SkillInfo.Default],
				Stats = [StatInfo.Default],
				ResumeDocID = "resume-john-doe",
				HomePageContent = HomePageContentInfo.Default,
				ResumeSectionIntro = ResumeSectionIntro.Default
			});
			return;
		}

		// Brand (Required)
		BrandInfoValidator.Validate(model.Brand, result, $"{path}.Brand");

		// Profile Image (Required)
		if (ValidatorHelpers.IsNullOrWhiteSpace(model.ProfileImageUrl))
			result.AddError($"{path}.{nameof(model.ProfileImageUrl)} is required.");

		// Social Links (Optional but list expected to contain valid links)
		for (int i = 0; i < model.SocialLinks.Count; i++)
			ExternalLinkValidator.Validate(model.SocialLinks[i], result, $"{path}.SocialLinks[{i}]");

		// Services (Required and must not be empty)
		if (model.Services is null || model.Services.Count == 0)
		{
			result.AddError($"{path}.{nameof(model.Services)} must contain at least one service.");
		}
		else
		{
			for (int i = 0; i < model.Services.Count; i++)
				ServiceInfoValidator.Validate(model.Services[i], result, $"{path}.Services[{i}]");
		}

		// Contact Links
		for (int i = 0; i < model.ContactLinks.Count; i++)
			ExternalLinkValidator.Validate(model.ContactLinks[i], result, $"{path}.ContactLinks[{i}]");

		// Projects
		for (int i = 0; i < model.Projects.Count; i++)
			ProjectInfoValidator.Validate(model.Projects[i], result, $"{path}.Projects[{i}]");

		// About Me
		AboutMeInfoValidator.Validate(model.AboutMeInfo, result, $"{path}.AboutMeInfo");

		// Experience Events
		for (int i = 0; i < model.ExperienceEvents.Count; i++)
		{
			ValidationRegistry.ValidateIfSupported(model.ExperienceEvents[i], result, $"{path}.ExperienceEvents[{i}]");
		}

		// Education Events
		for (int i = 0; i < model.EducationEvents.Count; i++)
		{
			ValidationRegistry.ValidateIfSupported(model.EducationEvents[i], result, $"{path}.EducationEvents[{i}]");
		}

		// Skills
		for (int i = 0; i < model.Skills.Count; i++)
			SkillInfoValidator.Validate(model.Skills[i], result, $"{path}.Skills[{i}]");

		// Stats
		for (int i = 0; i < model.Stats.Count; i++)
			StatInfoValidator.Validate(model.Stats[i], result, $"{path}.Stats[{i}]");

		// ResumeDocID (Required)
		if (ValidatorHelpers.IsNullOrWhiteSpace(model.ResumeDocID))
			result.AddError($"{path}.{nameof(model.ResumeDocID)} is required.");

		// HomePageContent
		HomePageContentInfoValidator.Validate(model.HomePageContent, result, $"{path}.HomePageContent");

		// ResumeSectionIntro
		ResumeSectionIntroValidator.Validate(model.ResumeSectionIntro, result, $"{path}.ResumeSectionIntro");

		if (!result.IsValid)
		{
			RegisterExample(result, new UserProfileData
			{
				Brand = BrandInfo.Default,
				ProfileImageUrl = "https://example.com/images/profile.jpg",
				SocialLinks = [ExternalLinkInfo.Default],
				Services = [ServiceInfo.Default],
				ContactLinks = [ExternalLinkInfo.Default],
				Projects = [ProjectInfo.Default],
				AboutMeInfo = AboutMeInfo.Default,
				ExperienceEvents = [DateEventInfo.Default, DateRangeEventInfo.Default],
				EducationEvents = [DateEventInfo.Default, DateRangeEventInfo.Default],
				Skills = [SkillInfo.Default],
				Stats = [StatInfo.Default],
				ResumeDocID = "resume-john-doe",
				HomePageContent = HomePageContentInfo.Default,
				ResumeSectionIntro = ResumeSectionIntro.Default
			});
		}
	}
}
