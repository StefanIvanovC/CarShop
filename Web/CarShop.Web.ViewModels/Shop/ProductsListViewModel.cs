namespace CarShop.Web.ViewModels.Shop
{
    using System.Collections.Generic;

    public class ProductsListViewModel
    {
        public IEnumerable<ProductsInListViewModel> ProductList { get; set; }

        public int ProductCount { get; set; }
    }
}
