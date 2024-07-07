using Management_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Management_Core.Controllers
{
    public class TheEmployeeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var results = c.Employees.Include(x=>x.Sectors).ToList();//Eager Loading -> Includes Sectors data associated with each employee in the query
            return View(results);
        }

        [HttpGet]
        public IActionResult newEmployee()
        {
            List<SelectListItem>sectors = (from x in c.Sectors.ToList()   //dropdownlist datas
                                           select new SelectListItem
                                           {
                                               Text = x.SectorName,
                                                Value= x.SectorID.ToString()
                                           }).ToList();
            ViewBag.sector = sectors;       //carrying datas to view
            return View();
        }

        public IActionResult newEmployee(Employee e)
        {
            var emp = c.Sectors.Where(x => x.SectorID == e.Sectors.SectorID).FirstOrDefault();
            e.Sectors = emp;
            c.Employees.Add(e);
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
        


    }
}
