using Microsoft.AspNetCore.Mvc;

namespace _3_Script_Link.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
