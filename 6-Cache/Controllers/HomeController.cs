using Microsoft.AspNetCore.Mvc;

namespace _6_Cache.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name)
        {
            Response.Cookies.Append("Name", name);

            return RedirectToAction("Profile");
        }

        public IActionResult Profile()
        {
            Console.WriteLine(Request.Cookies["Name"]);
            return View();
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("Name");
            return RedirectToAction("Login");
        }
    }
}
