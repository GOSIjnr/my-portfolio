namespace MyPortfolio.Core.Validation;

public class ValidationResult
{
	private readonly List<string> _errors = [];
	private readonly List<string> _warnings = [];
	private readonly Dictionary<string, string> _yamlExamples = [];

	public IReadOnlyList<string> Errors => _errors;
	public IReadOnlyList<string> Warnings => _warnings;
	public IReadOnlyDictionary<string, string> Examples => _yamlExamples;

	public bool IsValid => _errors.Count == 0;

	public void AddError(string message) => _errors.Add(message);
	public void AddWarning(string message) => _warnings.Add(message);

	public void RegisterExample(string key, string yaml)
	{
		if (!_yamlExamples.ContainsKey(key))
		{
			_yamlExamples[key] = yaml;
		}
	}
}