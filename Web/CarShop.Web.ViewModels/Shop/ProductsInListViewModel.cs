namespace CarShop.Web.ViewModels.Shop
{
    using CarShop.Data.Models;
    using CarShop.Services.Mapping;

    public class ProductsInListViewModel : IMapFrom<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
    }
}
