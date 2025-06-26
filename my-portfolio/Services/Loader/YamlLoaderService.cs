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

	public async Task<T> LoadYamlAsync<T>(string path)
	{
		try
		{
			var yaml = await _http.GetStringAsync(path);
			Console.WriteLine("YAML content received:");
			Console.WriteLine(yaml);

			return _deserializer.Deserialize<T>(yaml)!;
		}
		catch (YamlDotNet.Core.YamlException yamlEx)
		{
			Console.WriteLine($"YAML Parsing Error: {yamlEx.Message}");
			Console.WriteLine($"Details: {yamlEx.InnerException?.Message}");
			throw;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"General Error: {ex.Message}");
			Console.WriteLine($"Details: {ex.InnerException?.Message}");
			throw;
		}
	}
}
