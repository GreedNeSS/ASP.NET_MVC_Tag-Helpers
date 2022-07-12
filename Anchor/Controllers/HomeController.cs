using Microsoft.AspNetCore.Mvc;
using Anchor.Models;
using System;

namespace Anchor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users(int? id)
        {
            string result = "Users Page";
            if (id.HasValue) result += $"\nId = {id}";
            return Content(result);
        }

        public IActionResult Person(Person person)
        {
            return Json(person);
        }
    }
}
