using MyPortfolio.Contracts.Validation;

namespace MyPortfolio.Core.Validation;

public static class ValidationRegistry
{
	private static readonly Dictionary<Type, Action<object, ValidationResult, string>> _validators = [];

	public static void Register<T>()
	{
		var type = typeof(T);

		if (_validators.ContainsKey(type))
		{
			throw new InvalidOperationException($"Validator for {type.Name} is already in registry.");
		}

		_validators[type] = (obj, result, path) => ValidatorBase<T>.Validate((T)obj, result, path);
	}

	public static void ValidateIfSupported(object model, ValidationResult result, string path, ILogger? logger = null)
	{
		Type? type = model.GetType();

		if (_validators.TryGetValue(type, out var validator))
		{
			validator(model, result, path);
		}
		else
		{
			logger?.LogError("No validator found for {TypeName}", type.Name);
		}
	}
}
