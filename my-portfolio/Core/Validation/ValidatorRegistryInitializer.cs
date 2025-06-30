using MyPortfolio.Contracts.Validation;
using MyPortfolio.Core.Validation.Models;
using MyPortfolio.Models.Common;
using MyPortfolio.Models.ContactForm;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Home;
using MyPortfolio.Models.InfoCard;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Resume;
using MyPortfolio.Models.Service;

namespace MyPortfolio.Core.Validation;

public static class ValidatorRegistryInitializer
{
	private static bool _initialized;

	public static void RegisterAll()
	{
		if (_initialized) return;
		_initialized = true;

		ValidatorBase<UserProfileData>.RegisterValidator(new UserProfileDataValidator());

		ValidatorBase<BrandInfo>.RegisterValidator(new BrandInfoValidator());
		ValidatorBase<ExternalLinkInfo>.RegisterValidator(new ExternalLinkValidator());
		ValidatorBase<ServiceInfo>.RegisterValidator(new ServiceInfoValidator());
		ValidatorBase<ProjectInfo>.RegisterValidator(new ProjectInfoValidator());
		ValidatorBase<SkillInfo>.RegisterValidator(new SkillInfoValidator());
		ValidatorBase<StatInfo>.RegisterValidator(new StatInfoValidator());
		ValidatorBase<AboutMeInfo>.RegisterValidator(new AboutMeInfoValidator());
		ValidatorBase<HomePageContentInfo>.RegisterValidator(new HomePageContentInfoValidator());
		ValidatorBase<ResumeSectionIntro>.RegisterValidator(new ResumeSectionIntroValidator());
		ValidatorBase<DateEventInfo>.RegisterValidator(new DateEventInfoValidator());
		ValidatorBase<DateRangeEventInfo>.RegisterValidator(new DateRangeEventInfoValidator());
		ValidatorBase<AppLayoutData>.RegisterValidator(new AppLayoutDataValidator());

		ValidatorBase<NavigationLinkInfo>.RegisterValidator(new NavigationLinkValidator());
		ValidatorBase<ContactFormInfo>.RegisterValidator(new ContactFormValidator());
		ValidatorBase<TabButtonInfo>.RegisterValidator(new TabButtonValidator());
		ValidatorBase<ResumeHeaderInfo>.RegisterValidator(new ResumeHeaderInfoValidator());
	}
}
