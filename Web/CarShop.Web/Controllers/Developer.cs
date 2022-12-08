using Microsoft.AspNetCore.Mvc;

namespace CarShop.Web.Controllers
{
    public class Developer : Controller
    {
        public IActionResult Info()
        {
            return this.View();
        }
    }
}
