using MyPortfolio.Contracts.InfoCard;
using MyPortfolio.Models.InfoCard;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyPortfolio.Services.Loader;

public class YamlLoaderService(HttpClient http, ILogger<YamlLoaderService> logger)
{
	private readonly HttpClient _http = http;
	private readonly ILogger<YamlLoaderService> _logger = logger;
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
			_logger.LogDebug("Loading YAML from: {Path}", path);
			string yaml = await _http.GetStringAsync(path);

			if (string.IsNullOrWhiteSpace(yaml))
			{
				throw new InvalidDataException("YAML file content is null or empty.");
			}

			var model = _deserializer.Deserialize<T>(yaml) ?? throw new InvalidDataException("Deserialized YAML returned null.");

			return model;
		}
		catch (YamlDotNet.Core.YamlException yamlEx)
		{
			_logger.LogError("YAML Parsing Error in '{path}': {Message}", [path, yamlEx.Message]);
			_logger.LogError("Details: {Message}", yamlEx.InnerException?.Message);
			return default;
		}
		catch (Exception ex)
		{
			_logger.LogError("Exception loading YAML from '{path}': {ex.Message}", [path, ex.Message]);
			return default;
		}
	}
}
