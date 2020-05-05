using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EndPoints.WebUI.Models;
using Core.Contract;

namespace EndPoints.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPruductRepo RepoPrc;
        public HomeController(IPruductRepo pruduct)
        {
            RepoPrc = pruduct;
        }

         

        public IActionResult Index(int pn=1)
        {
            var pr=RepoPrc.GetProducts(2, pn);
            var fg = pr.ToList();
            return View(fg);
 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
