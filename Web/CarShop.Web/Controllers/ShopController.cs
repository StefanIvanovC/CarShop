namespace CarShop.Web.Controllers
{
    using CarShop.Data.Models;
    using CarShop.Web.ViewModels.Shop;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

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
            var userName = this.User.Identity.Name;
            var viewModel = new ByIdPointsViewModel()
            {
                UserName = userName,
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
