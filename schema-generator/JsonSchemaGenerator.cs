using NJsonSchema;

namespace SchemaGenerator;

public static class JsonSchemaGenerator
{
	public static void GenerateSchemaToUserFolder<T>(string? fileName = null)
	{
		fileName ??= typeof(T).Name + ".schema.json";

		string? outputDir = TryGetFolder(Environment.SpecialFolder.UserProfile, "Downloads")
							?? TryGetFolder(Environment.SpecialFolder.DesktopDirectory)
							?? Directory.GetCurrentDirectory();

		Directory.CreateDirectory(outputDir);
		string outputPath = Path.Combine(outputDir, fileName);

		var schema = JsonSchema.FromType<T>();
		string json = schema.ToJson();

		File.WriteAllText(outputPath, json);
		Console.WriteLine($"✅ Schema written to: {outputPath}");
	}

	private static string? TryGetFolder(Environment.SpecialFolder baseFolder, string? subFolder = null)
	{
		try
		{
			string basePath = Environment.GetFolderPath(baseFolder);
			return subFolder != null ? Path.Combine(basePath, subFolder) : basePath;
		}
		catch
		{
			return null;
		}
	}
}
