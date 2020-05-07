using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using EndPoints.WebUI.Models.Producte;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoints.WebUI.Controllers
{
    public class ProuductController : Controller
    {
        // GET: /<controller>/
        private readonly IPruductRepo RepoPrc;
        public ProuductController(IPruductRepo pruduct)
        {
            RepoPrc = pruduct;
        }


        public IActionResult Index(int pn = 1)
        {
            var pr = RepoPrc.GetProducts(3, pn).ToList();

            ProductsListViewModel prlvm = new ProductsListViewModel()
            {
                Products = pr,
                PagingInfo = new Models.Commons.PagingInfo
                {
                    CurrentPage=pn,
                    TotalItems=RepoPrc.TotalCount(),
                    ItemsPerPage=2
                    
                },
                //CurrentCategory=
            };


            return View(prlvm);
        }
    }
}
