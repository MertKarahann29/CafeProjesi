using System.Net.Mail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vivaldikafe1.Models;

namespace Vivaldikafe1.Controllers
{
    public class SogukKahveController : Controller
    {
        MyAppContext _context = new MyAppContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Index(SogukKahve sogukKahve)
        {

            _context.Add(sogukKahve);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Menü()
        {
            var SogukKahveList = _context.sogukKahves.ToList();
            return View(SogukKahveList);
        }
    }

}
