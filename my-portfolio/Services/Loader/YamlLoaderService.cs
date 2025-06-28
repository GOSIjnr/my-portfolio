// --- YamlLoaderService.cs ---
using MyPortfolio.Models.Data;
using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Models.InfoCard;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyPortfolio.Services.Loader;

public class YamlLoaderService(HttpClient http)
{
	private readonly HttpClient _http = http;
	private readonly IDeserializer _deserializer = new DeserializerBuilder()
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

	public async Task<T?> LoadYamlAsync<T>(string path)
	{
		try
		{
			Console.WriteLine($"📦 Loading YAML from: {path}");
			string yaml = await _http.GetStringAsync(path);

			if (string.IsNullOrWhiteSpace(yaml))
				throw new InvalidDataException("YAML file content is null or empty.");

			var model = _deserializer.Deserialize<T>(yaml);
			if (model is null)
				throw new InvalidDataException("Deserialized YAML returned null.");

			var result = new ValidationResult();
			ValidationRegistry.ValidateIfSupported(model, result, $"YAML<{typeof(T).Name}>");

			if (!result.IsValid)
			{
				Console.Error.WriteLine("❌ Validation failed:");
				foreach (var err in result.Errors)
					Console.Error.WriteLine($"  - {err}");

				throw new InvalidDataException($"❌ Failed to load or validate '{path}'.");
			}

			foreach (var warn in result.Warnings)
				Console.WriteLine($"⚠️  {warn}");

			return model;
		}
		catch (YamlDotNet.Core.YamlException yamlEx)
		{
			Console.Error.WriteLine($"YAML Parsing Error in '{path}': {yamlEx.Message}");
			Console.Error.WriteLine($"Details: {yamlEx.InnerException?.Message}");
			return default;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine($"❌ Exception loading YAML from '{path}': {ex.Message}");
			Console.Error.WriteLine($"Details: {ex.InnerException?.Message}");
			return default;
		}
	}
}
