namespace CarShop.Web.Controllers
{
    using CarShop.Services.Data;
    using CarShop.Web.ViewModels.Cars;
    using CarShop.Web.ViewModels.Search;
    using Microsoft.AspNetCore.Mvc;

    public class SearchController : BaseController
    {
        private readonly ICarService carService;

        public SearchController(ICarService carService)
        {
            this.carService = carService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult List(SearchListInputModel input)
        {
            var cars = new CarListViewModel()
            {
                Cars = this.carService.GetAllSearch(input.MinPrice, input.MaxPrice, input.EngineId, input.Millage, input.RegionName),
            };

            return this.View(cars);
        }
    }
}
