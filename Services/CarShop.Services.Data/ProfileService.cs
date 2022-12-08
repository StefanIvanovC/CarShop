namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    using CarShop.Web.ViewModels.MyProfile;

    public class ProfileService : IProfileService
    {
        private IDeletableEntityRepository<Car> carsRepository;

        public ProfileService(IDeletableEntityRepository<Car> carsRepository)
        {
            this.carsRepository = carsRepository;
        }

        public IEnumerable<MyCarsInListViewModel> MyCars(string userId)
        {
            var cars = this.carsRepository.All().Where(x => x.CreatedByUserId == userId).To<MyCarsInListViewModel>().ToList();

            return cars;
        }
    }
}
