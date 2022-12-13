namespace CarShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TaxController : Controller
    {
        public IActionResult Calculator()
        {
            return this.View();
        }
    }
}
