namespace MyPortfolio.Models.Navigation;

public class NavigationBrandInfo(string logoImagePath, string brandDisplayName, string logoAltText)
{
	private string _logoImagePath = logoImagePath ?? string.Empty;
	private string _brandDisplayName = brandDisplayName ?? string.Empty;
	private string _logoAltText = logoAltText ?? string.Empty;

	public string LogoImagePath
	{
		get { return _logoImagePath; }
		set { _logoImagePath = value ?? string.Empty; }
	}

	public string BrandDisplayName
	{
		get { return _brandDisplayName; }
		set { _brandDisplayName = value ?? string.Empty; }
	}

	public string LogoAltText
	{
		get { return _logoAltText; }
		set { _logoAltText = value ?? string.Empty; }
	}

	public NavigationBrandInfo() : this(string.Empty, "Lorem ipsum", string.Empty) { }
}
