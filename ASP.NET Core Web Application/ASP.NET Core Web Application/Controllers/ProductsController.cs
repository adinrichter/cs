using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_Application.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
