namespace CarShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ShopController : Controller
    {
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
            return this.View();
        }

        public IActionResult Add()
        {
            return this.View();
        }
    }
}
