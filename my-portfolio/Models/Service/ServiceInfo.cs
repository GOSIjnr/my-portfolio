using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.Service;

public class ServiceInfo
{
	[Required] public required string Name { get; init; }
	[Required] public required string Description { get; init; }
}
