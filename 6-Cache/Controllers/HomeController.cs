using Microsoft.AspNetCore.Mvc;

namespace _6_Cache.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            Console.WriteLine(Request.Cookies["Name"]);
            Console.WriteLine(User.Identity.Name);
            return View();
        }
    }
}
