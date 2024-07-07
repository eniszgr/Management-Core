using Management_Core.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Management_Core.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult logIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> logIn(Admin a) {
            var infos = c.Admins.FirstOrDefault(x => x.User == a.User && x.Password == a.Password);
            if (infos != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.User) //type and value
                };

                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "TheEmployee");

            }
            return View();
        }
    }
}
