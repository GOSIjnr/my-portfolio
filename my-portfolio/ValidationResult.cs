// --- ValidationResult.cs ---
using MyPortfolio.Models.Common;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Navigation;
using MyPortfolio.Models.Project;
using MyPortfolio.Models.Service;

public class ValidationResult
{
	public bool IsValid => Errors.Count == 0;
	public List<string> Errors { get; } = new();
	public List<string> Warnings { get; } = new();

	public void AddError(string message) => Errors.Add(message);
	public void AddWarning(string message) => Warnings.Add(message);
}

// --- IValidatable.cs ---
public interface IValidatable
{
	void Validate(ValidationResult result, string path = "");
}

// --- ValidatorHelpers.cs ---
public static class ValidatorHelpers
{
	public static bool IsNullOrWhiteSpace(string? input) => string.IsNullOrWhiteSpace(input);
}

// --- BrandInfoValidator.cs ---
public static class BrandInfoValidator
{
	public static void Validate(BrandInfo brand, ValidationResult result, string path)
	{
		Console.WriteLine($"path: {path}");
		if (brand is null)
		{
			result.AddError($"{path}.Brand is null.");
			return;
		}

		if (ValidatorHelpers.IsNullOrWhiteSpace(brand.BrandDisplayName))
			result.AddError($"{path}.BrandDisplayName is required. Suggestion: Set a non-empty brand name.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(brand.BrandHighlightedDisplayName))
			result.AddWarning($"{path}.BrandHighlightedDisplayName is null. Suggestion: Add a highlight name.");

		if (ValidatorHelpers.IsNullOrWhiteSpace(brand.BrandRawTargetUrl))
			result.AddWarning($"{path}.BrandRawTargetUrl is null. Suggestion: Add a brand image URL.");
	}
}

// --- ExternalLinkValidator.cs ---
public static class ExternalLinkValidator
{
	public static void Validate(ExternalLinkInfo link, ValidationResult result, string path)
	{
		Console.WriteLine($"path: {path}");

		if (ValidatorHelpers.IsNullOrWhiteSpace(link.LinkUrl))
			result.AddError($"{path}.LinkUrl is required. Suggestion: Provide a valid URL.");
	}
}

// --- ServiceInfoValidator.cs ---
public static class ServiceInfoValidator
{
	public static void Validate(ServiceInfo service, ValidationResult result, string path)
	{
		if (ValidatorHelpers.IsNullOrWhiteSpace(service.Name))
			result.AddError($"{path}.Name is required.");
		if (ValidatorHelpers.IsNullOrWhiteSpace(service.Description))
			result.AddWarning($"{path}.Description is missing. Suggestion: Add a brief description.");
	}
}

// --- ProjectInfoValidator.cs ---
public static class ProjectInfoValidator
{
	public static void Validate(ProjectInfo project, ValidationResult result, string path)
	{
		if (ValidatorHelpers.IsNullOrWhiteSpace(project.Title))
			result.AddError($"{path}.Title is required.");
		if (ValidatorHelpers.IsNullOrWhiteSpace(project.Description))
			result.AddError($"{path}.Description is required.");

		if (project.LiveLink is not null)
			ExternalLinkValidator.Validate(project.LiveLink, result, $"{path}.LiveLink");

		if (project.OtherLinks != null)
		{
			foreach (var (link, i) in project.OtherLinks.Select((v, i) => (v, i)))
				ExternalLinkValidator.Validate(link, result, $"{path}.OtherLinks[{i}]");
		}
	}
}

// --- UserProfileDataValidator.cs ---
public static class UserProfileDataValidator
{
	public static void Validate(UserProfileData data, ValidationResult result, string path = "UserProfileData")
	{
		BrandInfoValidator.Validate(data.Brand, result, $"{path}.Brand");

		foreach (var (link, i) in data.SocialLinks.Select((v, i) => (v, i)))
			ExternalLinkValidator.Validate(link, result, $"{path}.SocialLinks[{i}]");

		foreach (var (link, i) in data.ContactLinks.Select((v, i) => (v, i)))
			ExternalLinkValidator.Validate(link, result, $"{path}.ContactLinks[{i}]");

		foreach (var (service, i) in data.Services.Select((v, i) => (v, i)))
			ServiceInfoValidator.Validate(service, result, $"{path}.Services[{i}]");

		foreach (var (project, i) in data.Projects.Select((v, i) => (v, i)))
			ProjectInfoValidator.Validate(project, result, $"{path}.Projects[{i}]");

		// Add similar calls for AboutMeInfo, ExperienceEvents, etc., if desired
	}
}

// --- ValidationRegistry.cs ---
public static class ValidationRegistry
{
	private static readonly Dictionary<Type, Action<object, ValidationResult, string>> _validators = new()
	{
		{ typeof(UserProfileData), (obj, result, path) => UserProfileDataValidator.Validate((UserProfileData)obj, result, path) },
        // { typeof(AppLayoutData), (obj, result, path) => AppLayoutDataValidator.Validate((AppLayoutData)obj, result, path) },
        // Add more validators as needed
    };

	public static void ValidateIfSupported(object model, ValidationResult result, string path)
	{
		var type = model.GetType();
		if (_validators.TryGetValue(type, out var validator))
		{
			validator(model, result, path);
		}
	}
}

