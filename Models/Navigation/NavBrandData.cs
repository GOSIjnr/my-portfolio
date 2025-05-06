namespace MyPortfolio.Models.Navigation;

public class NavBrandData(string logoImagePath, string brandDisplayName, string logoAltText = "Project Logo")
{
	public string LogoImagePath { get; set; } = logoImagePath;
	public string BrandDisplayName { get; set; } = brandDisplayName;
	public string LogoAltText { get; set; } = logoAltText;
}
