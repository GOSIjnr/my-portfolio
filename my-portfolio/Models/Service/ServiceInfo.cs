namespace MyPortfolio.Models.Service;

public class ServiceInfo
{
	public required string Name { get; init; }
	public required string Description { get; init; }

	public static ServiceInfo Default => new()
	{
		Name = "Lorem ipsum",
		Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Scelerisque consequat, faucibus et, et."
	};
}
