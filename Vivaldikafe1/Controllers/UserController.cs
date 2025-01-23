using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vivaldikafe1.Models;

public class UserController : Controller
{
    public IActionResult Giris()
    {
        return View();
    }

    MyAppContext _context = new MyAppContext();
    [HttpPost]
    public async Task <IActionResult> Giris (string kullaniciAd, string sifre)
    {
        if (string.IsNullOrEmpty(kullaniciAd) || string.IsNullOrEmpty(sifre))
        {
            ModelState.AddModelError("", "Lütfen e-posta ve şifre alanlarını doldurunuz.");
            return View();
        }
         var kullanici=await _context.users.FirstOrDefaultAsync(k=>k.KullaniciAd==kullaniciAd && k.sifre==sifre);

        if (kullanici == null)
        {
            ModelState.AddModelError("", "Geçersiz Kullanıcı adı veya şifre.");
            return View();
        }

        HttpContext.Session.SetString("KullaniciId", kullanici.KullaniciID.ToString());
        HttpContext.Session.SetString("KullaniciRol", kullanici.role);
        HttpContext.Session.SetString("KullaniciAdi", $"{kullanici.KullaniciAd}");
        return RedirectToAction("Index", "Home");

    }
    public IActionResult OturumKapat()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }


}