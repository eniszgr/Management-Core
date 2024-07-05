using Management_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Management_Core.Controllers
{
    public class TheEmployeeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var results = c.Employees.Include(x=>x.Sectors).ToList();
            return View(results);
        }
    }
}
