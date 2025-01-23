using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Vivaldikafe1.Models;

namespace Vivaldikafe1.Controllers
{
    public class MusteriController : Controller
    {
        MyAppContext _context= new MyAppContext();
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(Musteri musteri){
            
            _context.Add(musteri);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Kayýt()
        {
            var musteriList = _context.musteriler.ToList();
            return View(musteriList);
        }
        

    }



 }    

        
