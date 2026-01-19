using MyPortfolio.Models.Service;

namespace MyPortfolio.Contracts.ContactForm;

public interface IContactFormDataService
{
	ServiceInfo? GetSelectedService();
	List<string> GetServiceNames();
}
