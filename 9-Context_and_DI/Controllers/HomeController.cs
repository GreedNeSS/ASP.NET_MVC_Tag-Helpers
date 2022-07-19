using Microsoft.AspNetCore.Mvc;

namespace _9_Context_and_DI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
