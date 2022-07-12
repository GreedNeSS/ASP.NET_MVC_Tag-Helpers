using Microsoft.AspNetCore.Mvc;
using System;

namespace _1_Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return Content("Contacts Page");
        }
    }
}
