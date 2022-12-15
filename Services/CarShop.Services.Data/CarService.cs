namespace CarShop.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;
    using CarShop.Web.ViewModels.Cars;
    using CarShop.Web.ViewModels.Search;

    public class CarService : ICarService
    {
        private readonly string[] estensions = new[] { "jpg", "png", "img" };
        private readonly IDeletableEntityRepository<Car> carsRepository;

        public CarService(IDeletableEntityRepository<Car> carsRepository)
        {
            this.carsRepository = carsRepository;
        }

        public async Task CreateAsync(CreateCarViewModel input, string userId, string imagePath)
        {
            var car = new Car
            {
                Price = input.Price,
                Description = input.Description,
                MarkId = input.MarkId,
                Email = input.Email,
                EngineId = input.EngineId,
                RegionId = input.RegionId,
                Year = input.Year,
                Milage = input.Milage,
                TransmissionId = input.TransmissionId,
                CreatedByUserId = userId,
                IsUsed = input.IsUsed,
                TelephoneNumber = input.TelephoneNumber,
            };

            foreach (var image in input.Images)
            {
                Directory.CreateDirectory($"{imagePath}/cars");
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!this.estensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extensions {extension}");
                }

                var dbImage = new Image
                {
                    CreatedByUserId = userId,
                    Extension = extension,
                };
                car.Images.Add(dbImage);

                var physicalPath = $@"{imagePath}/cars/{dbImage.Id}.{extension}";

                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.carsRepository.AddAsync(car);
            await this.carsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var carIdDelete = this.carsRepository.All().FirstOrDefault(c => c.Id == id);
            this.carsRepository.Delete(carIdDelete);
            await this.carsRepository.SaveChangesAsync();
        }

        public IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = 4)
        {
            var car = this.carsRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<CarInListViewModel>()
                .ToList();

            return car;
        }

        public IEnumerable<CarInListViewModel> GetAllSearch(int minPrice, int maxPrice, uint engineId, int millage, string regionName)
        {
            var cars = this.carsRepository.AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .To<CarInListViewModel>()
                .ToList();

            if (regionName != "All")
            {
                cars = cars.Where(x => x.RegionName == regionName).ToList();
            }

            if (engineId != 0)
            {
                cars = cars.Where(x => x.EngineId == engineId).ToList();
            }

            if (minPrice != 0)
            {
                cars = cars.Where(x => x.Price >= minPrice).ToList();
            }

            if (maxPrice != 0)
            {
                cars = cars.Where(x => x.Price <= maxPrice).ToList();
            }

            if (millage != 0)
            {
                cars = cars.Where(c => c.Milage < millage).ToList();
            }

            return cars;
        }

        public T GetById<T>(int id)
        {
            var car = this.carsRepository.AllAsNoTracking()
                .Where(c => c.Id == id)
                .To<T>().FirstOrDefault();

            return car;
        }

        public int GetCount()
        {
            return this.carsRepository.All().Count();
        }
    }
}
