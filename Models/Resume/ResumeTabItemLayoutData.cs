using MyPortfolio.Helpers.Utilities;

namespace MyPortfolio.Models.Resume;

public class ResumeTabItemLayoutData(string key, string label)
{
	private string _key = key ?? string.Empty;
	private string _label = label ?? string.Empty;

	public string Key
	{
		get => _key;
		set => _key = value ?? string.Empty;
	}

	public string Label
	{
		get => _label;
		set => _label = value ?? string.Empty;
	}

	public ResumeTabItemLayoutData() : this("LoremIspum", "Lorem ispum") { }

	public ResumeTabItemLayoutData(string label) : this(label.ToPascalCase(), label) { }
}
