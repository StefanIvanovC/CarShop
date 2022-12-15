namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CarShop.Web.ViewModels.Cars;

    public interface ICarService
    {
        Task CreateAsync(CreateCarViewModel input, string userId, string imagePath);

        IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = 4);

        int GetCount();

        T GetById<T>(int id);

        Task DeleteAsync(int id);

        IEnumerable<CarInListViewModel> GetAllSearch(int minPrice, int maxPrice, uint engineId, int millage, string regionName);
    }
}
