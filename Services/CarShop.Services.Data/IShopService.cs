namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CarShop.Web.ViewModels.Shop;

    public interface IShopService
    {
        Task AddAsync(AddItemShopInputModel input, string userId);

        IEnumerable<ProductsInListViewModel> GetAllProducts();

        int GetCount();
    }
}
