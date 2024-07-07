using Microsoft.AspNetCore.Mvc;

namespace Management_Core.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult logIn()
        {
            return View();
        }
    }
}
