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

        public IActionResult deleteSector(int id)
        {
            var dep = c.Sectors.Find(id);
            c.Sectors.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult getSector(int id)
        {
            var depart = c.Sectors.Find(id);
            return View("getSector", depart);
        }

        public IActionResult updateSector(Sector s)
        {
            var dep = c.Sectors.Find(s.SectorID);
            dep.SectorName = s.SectorName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
