using MyPortfolio.Models.Service;

namespace MyPortfolio.Services.StateManagement
{
	public class SelectedServiceState
	{
		private ServiceInfo? _selectedService;

		public void SetSelectedService(ServiceInfo service)
		{
			_selectedService = service;
		}

		public ServiceInfo? ConsumeSelectedService()
		{
			ServiceInfo? service = _selectedService;
			_selectedService = null;
			return service;
		}
	}
}
