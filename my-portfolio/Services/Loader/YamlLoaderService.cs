using System.ComponentModel.DataAnnotations;
using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Models.InfoCard;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyPortfolio.Services.Loader;

public class YamlLoaderService(HttpClient http, ILogger<YamlLoaderService> logger)
{
	private readonly HttpClient _http = http;
	private readonly ILogger<YamlLoaderService> _logger = logger;

	private static readonly IDeserializer _validatedDeserializer = new DeserializerBuilder()
		.WithNamingConvention(CamelCaseNamingConvention.Instance)
		.WithTypeDiscriminatingNodeDeserializer(options =>
		{
			options.AddKeyValueTypeDiscriminator<InfoEventBase>(
				"type",
				new Dictionary<string, Type>
				{
					{ "date", typeof(DateEventInfo) },
					{ "dateRange", typeof(DateRangeEventInfo) },
				}
			);
		})
		.IgnoreUnmatchedProperties()
		.Build();

	public async Task<T?> LoadYamlAsync<T>(string yamlPath, CancellationToken cancellationToken = default)
	{
		try
		{
			_logger.LogInformation("Loading YAML from: {Path}", yamlPath);
			string yaml = await _http.GetStringAsync(yamlPath, cancellationToken);

			if (string.IsNullOrWhiteSpace(yaml))
				throw new InvalidDataException("YAML content is null or empty.");

			T model = _validatedDeserializer.Deserialize<T>(yaml)
				?? throw new InvalidDataException("Deserialization returned null.");

			ValidateModel(model);

			return model;
		}
		catch (ValidationException vex)
		{
			_logger.LogError("Validation error: {Message}", vex.Message);
			return default;
		}
		catch (YamlException yex)
		{
			_logger.LogError("YAML deserialization error in '{Path}': {Message}", yamlPath, yex.Message);
			return default;
		}
		catch (Exception ex)
		{
			_logger.LogError("General error loading YAML '{Path}': {Message}", yamlPath, ex.Message);
			return default;
		}
	}

	private static void ValidateModel<T>(T model)
	{
		var validationContext = new ValidationContext(model!);
		var validationResults = new List<ValidationResult>();

		if (!Validator.TryValidateObject(model!, validationContext, validationResults, validateAllProperties: true))
		{
			var errorMessages = string.Join("; ", validationResults.Select(r => r.ErrorMessage));
			throw new ValidationException($"Validation failed: {errorMessages}");
		}
	}
}
