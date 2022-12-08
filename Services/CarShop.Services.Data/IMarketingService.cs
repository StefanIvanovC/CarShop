namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CarShop.Web.ViewModels.Marketing;

    public interface IMarketingService
    {
        Task CreateAsynk(CreateEmailMarketingViewModel input, string user);

        IEnumerable<MarketingInListViewModel> GetAll();

        int GetCount();

        Task DeleteAsync(string id);
    }
}
