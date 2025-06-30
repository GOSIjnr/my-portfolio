using MyPortfolio.Core.Validation;
using MyPortfolio.Services.Loader;

namespace MyPortfolio.Contracts.Validation;

public abstract class ValidatorBase<T>
{
	private static ValidatorBase<T>? _instance;

	public static void RegisterValidator(ValidatorBase<T> instance)
	{
		if (_instance is not null)
		{
			throw new InvalidOperationException($"Validator for {typeof(T).Name} is already registered.");
		}

		_instance = instance;
		ValidationRegistry.Register<T>();
	}

	public abstract void ValidateModel(T model, ValidationResult result, string path);

	public static void Validate(T model, ValidationResult result, string path)
	{
		if (_instance is null)
		{
			throw new InvalidOperationException($"Validator for {typeof(T).Name} has not been registered.");
		}

		_instance.ValidateModel(model, result, path);
	}

	protected void RegisterExample(ValidationResult result, T modelDefault)
	{
#if DEBUG
		var yamlData = YamlGenerator.Generate(modelDefault);
		result.RegisterExample(typeof(T).Name, yamlData);
#endif
	}
}
