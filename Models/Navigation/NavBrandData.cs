namespace MyPortfolio.Models.Navigation;

public class NavBrandData(string logoPath, string projectName, string altText = "Project Logo")
{
	public string LogoPath { get; set; } = logoPath;
	public string ProjectName { get; set; } = projectName;
	public string AltText { get; set; } = altText;
}
