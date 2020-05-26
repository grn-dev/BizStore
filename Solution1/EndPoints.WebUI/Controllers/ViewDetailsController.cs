using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using EndPoints.WebUI.Models.ViewDetails;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.WebUI.Controllers
{
    public class ViewDetailsController : Controller
    {

        private readonly IPruductRepo RepoPrc;
        public ViewDetailsController(IPruductRepo pruduct)
        {
            RepoPrc = pruduct;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShoeDetail(int PrucuctId)
        {
            var main = RepoPrc.Get(PrucuctId);
            var rele = RepoPrc.GetReletionPruduct(main);

            ViewDetailsViewModel mdl = new ViewDetailsViewModel()
            {
                MainProduct = main,
                ReletionProduct = rele

            };

            return View(mdl);
        }
    }
}