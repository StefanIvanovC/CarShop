namespace CarShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class Developer : Controller
    {
        public IActionResult Info()
        {
            return this.View();
        }
    }
}
