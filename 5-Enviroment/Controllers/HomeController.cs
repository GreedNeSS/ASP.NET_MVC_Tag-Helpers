using Microsoft.AspNetCore.Mvc;

namespace _5_Enviroment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
