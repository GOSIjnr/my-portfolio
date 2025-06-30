// --- ProjectInfoValidator.cs ---
// --- ProjectInfoValidator.cs ---
public static class ProjectInfoValidator
{
	// public static void Validate(ProjectInfo project, ValidationResult result, string path)
	// {
	// 	if (ValidatorHelpers.IsNullOrWhiteSpace(project.Title))
	// 		result.AddError($"{path}.Title is required.");
	// 	if (ValidatorHelpers.IsNullOrWhiteSpace(project.Description))
	// 		result.AddError($"{path}.Description is required.");

	// 	if (project.LiveLink is not null)
	// 		ExternalLinkValidator.Validate(project.LiveLink, result, $"{path}.LiveLink");

	// 	if (project.OtherLinks != null)
	// 	{
	// 		foreach (var (link, i) in project.OtherLinks.Select((v, i) => (v, i)))
	// 			ExternalLinkValidator.Validate(link, result, $"{path}.OtherLinks[{i}]");
	// 	}
	// }
}

