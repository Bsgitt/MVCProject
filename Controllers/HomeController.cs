using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCpresent.Models;
using Microsoft.AspNetCore.Mvc.Razor;


namespace MVCpresent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var fullName = ("bas","Nantaphong");
            ViewData["myname"] = fullName.Item1+ " "+fullName.Item2;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
