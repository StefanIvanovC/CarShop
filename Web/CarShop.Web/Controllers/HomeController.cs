namespace CarShop.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using CarShop.Data;
    using CarShop.Web.ViewModels;
    using CarShop.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                CarCount = this.db.Cars.Count(),
                MarkCount = this.db.Marks.Count(),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }
    }
}
