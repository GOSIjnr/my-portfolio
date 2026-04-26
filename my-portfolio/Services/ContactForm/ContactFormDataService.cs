using MyPortfolio.Contracts.ContactForm;
using MyPortfolio.Models.Data;
using MyPortfolio.Models.Service;
using MyPortfolio.Services.StateManagement;

namespace MyPortfolio.Services.ContactForm;

public class ContactFormDataService(PortfolioData portfolioData, SelectedServiceState selectedServiceState) : IContactFormDataService
{
	private readonly PortfolioData _portfolioData = portfolioData;
	private readonly SelectedServiceState _selectedServiceState = selectedServiceState;

	public ServiceInfo? GetSelectedService()
	{
		return _selectedServiceState.ConsumeSelectedService();
	}

	public List<string> GetServiceNames()
	{
		List<string> names = [.. _portfolioData.User.Services.Select(s => s.Name)];
		names.Add("Others");
		return names;
	}
}
