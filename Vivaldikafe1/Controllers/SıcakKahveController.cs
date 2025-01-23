using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Vivaldikafe1.Models;

namespace Vivaldikafe1.Controllers
{
    public class SıcakKahveController : Controller
    {
        MyAppContext _context = new MyAppContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SıcakKahve sıcakKahve)
        {

            _context.Add(sıcakKahve);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Menü()
        {
            var SıcakKahveList = _context.sıcakKahves.ToList();
            return View(SıcakKahveList);
        }
    }

}
