namespace CarShop.Web.Controllers
{
    using CarShop.Data.Models;
    using CarShop.Web.ViewModels.Cars;
    using CarShop.Web.ViewModels.Shop;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ShopController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ShopController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult RedirectTo()
        {
            return this.View();
        }

        public IActionResult All()
        {
            return this.View();
        }

        public IActionResult Points()
        {
            //ToDo. Get userPoints from cookie
            var user = this.userManager.GetUserAsync(this.User);
            var viewModel = new ByIdPointsViewModel()
            {
                PointsCount = 1,
            };
            return this.View(viewModel);
        }

        public IActionResult Add()
        {
            return this.View();
        }
    }
}
