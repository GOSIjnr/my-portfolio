namespace MyPortfolio.Models.UI;

public class SocialMediaIconInfo(string platformName, string iconImageUrl, string profilePageUrl, string iconAltText)
{
	private string _platformName = platformName ?? string.Empty;
	private string _iconImageUrl = iconImageUrl ?? string.Empty;
	private string _profilePageUrl = profilePageUrl ?? string.Empty;
	private string _iconAltText = iconAltText ?? string.Empty;

	public string PlatformName
	{
		get { return _platformName; }
		set { _platformName = value ?? string.Empty; }
	}

	public string IconImageUrl
	{
		get { return _iconImageUrl; }
		set { _iconImageUrl = value ?? string.Empty; }
	}

	public string ProfilePageUrl
	{
		get { return _profilePageUrl; }
		set { _profilePageUrl = value ?? string.Empty; }
	}

	public string IconAltText
	{
		get { return _iconAltText; }
		set { _iconAltText = value ?? string.Empty; }
	}

	public SocialMediaIconInfo() : this("Lorem ispum", string.Empty, string.Empty, string.Empty) { }
}
