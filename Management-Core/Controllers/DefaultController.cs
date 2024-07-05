using Management_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Management_Core.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var result = c.Sectors.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult newSector()
        {
            return View();
        }
        [HttpPost]
        public IActionResult newSector(Sector s)
        {

            c.Sectors.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
