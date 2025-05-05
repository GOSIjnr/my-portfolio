using MyPortfolio.Models.Navigation;

namespace MyPortfolio.Contracts;

public interface IPageData
{
	NavBrandData BrandInfo { get; }
	NavLinkItemData[] NavLinkItems { get; }
	NavLinkItemData ContactData { get; }
}
