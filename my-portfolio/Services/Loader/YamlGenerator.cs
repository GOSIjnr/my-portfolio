using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace MyPortfolio.Services.Loader;

public static class YamlGenerator
{
	private static readonly ISerializer _serializer = new SerializerBuilder()
		.WithNamingConvention(CamelCaseNamingConvention.Instance)
		.ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitDefaults)
		.Build();

	public static string Generate<T>(T model)
	{
		return _serializer.Serialize(model);
	}
}
