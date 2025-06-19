namespace MyPortfolio.Models.Common;

public class SkillInfo(string skillName, string iconUrl)
{
	private string _skillName = skillName ?? string.Empty;
	private string _iconUrl = iconUrl ?? string.Empty;

	public string SkillName
	{
		get => _skillName;
		set => _skillName = value ?? string.Empty;
	}

	public string IconUrl
	{
		get => _iconUrl;
		set => _iconUrl = value ?? string.Empty;
	}

	public SkillInfo() : this("Lorem ispum", "images/web.svg") { }
}
