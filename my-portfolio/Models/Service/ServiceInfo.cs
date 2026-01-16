using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Service;

public class ServiceInfo
{
	[Required] public required string Name { get; init; }
	[Required] public required string Description { get; init; }

	public static readonly ServiceInfo Default = new()
	{
		Name = string.Empty,
		Description = string.Empty,
	};
}
