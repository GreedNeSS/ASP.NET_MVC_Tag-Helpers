using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace _6_Cache.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name)
        {
            Response.Cookies.Append("Name", name);
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, name) };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Redirect("/home/profile");
            return SignIn(new ClaimsPrincipal(identity));
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("Name");
            Response.Redirect("/auth/login");
            return SignOut(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
