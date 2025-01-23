using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vivaldikafe1.Models;

namespace Vivaldikafe1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }


}
