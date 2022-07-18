using Microsoft.AspNetCore.Mvc;
using _8_OutputControl.Models;

namespace _8_OutputControl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Styles = new Styles()
            {
                Color = "red",
                FontSize = 20,
                FontFamily = "Verdana"
            };
            return View();
        }
    }
}
