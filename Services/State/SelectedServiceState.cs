using MyPortfolio.Models.Services;

namespace MyPortfolio.Services.State;

public class SelectedServiceState
{
	private ServiceInfo? _selectedService;

	public void SetSelectedService(ServiceInfo service)
	{
		_selectedService = service;
	}

	public ServiceInfo? ConsumeSelectedService()
	{
		var service = _selectedService;
		_selectedService = null;
		return service;
	}
}
