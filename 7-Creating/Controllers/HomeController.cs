using Microsoft.AspNetCore.Mvc;

namespace _7_Creating.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
