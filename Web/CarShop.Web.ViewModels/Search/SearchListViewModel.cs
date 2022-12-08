namespace CarShop.Web.ViewModels.Search
{
    using System.Collections.Generic;

    using CarShop.Web.ViewModels.Cars;

    public class SearchListViewModel
    {
        public IEnumerable<CarInListViewModel> Cars { get; set; }
    }
}
