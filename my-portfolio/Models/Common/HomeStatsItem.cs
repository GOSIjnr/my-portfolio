namespace MyPortfolio.Models.Common;

public class HomeStatItem(string number, string description)
{
	private string _number = number ?? string.Empty;
	private string _description = description ?? string.Empty;

	public string Number
	{
		get => _number;
		set => _number = value ?? string.Empty;
	}

	public string Description
	{
		get => _description;
		set => _description = value ?? string.Empty;
	}

	public HomeStatItem() : this("0", "No data <br>available") { }
}
