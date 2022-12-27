namespace CarShop.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return this.View();
        }
    }
}
