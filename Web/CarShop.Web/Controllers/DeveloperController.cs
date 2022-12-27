namespace CarShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class DeveloperController : Controller
    {
        public IActionResult Info()
        {
            return this.View();
        }
    }
}
