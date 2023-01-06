namespace CarShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;
    using CarShop.Web.ViewModels.Shop;

    public class ShopService : IShopService
    {
        private readonly IDeletableEntityRepository<Product> productRepository;

        public ShopService(IDeletableEntityRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task AddAsync(AddItemShopInputModel input, string userId)
        {
            var product = new Product
            {
                Name = input.Name,
                Description = input.Description,
                Price = input.Price,
            };

            await this.productRepository.AddAsync(product);
            await this.productRepository.SaveChangesAsync();
        }

        public IEnumerable<ProductsInListViewModel> GetAllProducts()
        {
            var products = this.productRepository.AllAsNoTracking()
                .OrderByDescending(p => p.CreatedOn)
                .To<ProductsInListViewModel>()
                .ToList();

            return products;
        }

        public int GetCount()
        {
            var countOfProducts = this.productRepository.AllAsNoTracking().Count();
            return countOfProducts;
        }
    }
}
