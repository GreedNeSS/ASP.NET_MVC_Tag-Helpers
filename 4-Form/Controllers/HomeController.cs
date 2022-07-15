using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using _4_Form.Models;
using System;

namespace _4_Form.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Company> companies = new List<Company>()
        {
            new Company(1, "Apple"),
            new Company(2, "Samsung"),
            new Company(3, "Google")
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Companies = new SelectList(companies, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            Company? company = companies.FirstOrDefault(c => c.Id == product.CompanyId);

            if (company == null)
            {
                return BadRequest(new {message = "Компании не существует"});
            }

            return Content($"Добавлен новый продукт: {product.Name} ({company.Name})");
        }

        [HttpGet]
        public IActionResult Enum()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enum(DayTimeModel model)
        {
            return Content(model.Period.ToString());
        }
    }
}
