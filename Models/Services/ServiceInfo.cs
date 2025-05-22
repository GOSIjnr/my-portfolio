namespace MyPortfolio.Models.Services;

public class ServiceInfo(string name, string description)
{
	private string _name = name;
	private string _description = description;

	public string Name
	{
		get => _name;
		set => _name = value ?? string.Empty;
	}

	public string Description
	{
		get => _description;
		set => _description = value ?? string.Empty;
	}

	public ServiceInfo() : this("Lorem ipsum", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Scelerisque consequat, faucibus et, et.") { }
}
