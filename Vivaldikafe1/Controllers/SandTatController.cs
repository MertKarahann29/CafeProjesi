using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Vivaldikafe1.Models;

namespace Vivaldikafe1.Controllers
{
    public class SandTatController : Controller
    {
        MyAppContext _context = new MyAppContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SandTat sandTat)
        {

            _context.Add(sandTat);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Menü()
        {
            var SandTatList = _context.sandTats.ToList();
            return View(SandTatList);
        }
    }

}
