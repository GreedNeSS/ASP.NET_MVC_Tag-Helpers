using Microsoft.AspNetCore.Mvc;
using _11_Models.Models;

namespace _11_Models.Controllers
{
    public class HomeController : Controller
    {
        List<string> country = new List<string>
        {
            "Russian",
            "USA",
            "Germany"
        };

        List<string> city = new List<string>
        {
            "Moscow",
            "New York",
            "Berlin"
        };

        Person person = new Person
        {
            Id = Guid.NewGuid(),
            Name = "GreedNeSS",
            Age = 31
        };

        public IActionResult Index()
        {
            ViewBag.Countries = country;
            ViewBag.Cities = city;
            ViewBag.Person = person;
            return View();
        }
    }
}
