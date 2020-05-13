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

         

        public IActionResult index(string catname,int pn = 1)
        {
            //?pn=2
            int showpage = 3;
            var pr = RepoPrc.GetProducts(showpage, pn, catname).ToList();

            ProductsListViewModel prlvm = new ProductsListViewModel()
            {
                Products = pr,
                PagingInfo = new Models.Commons.PagingInfo
                {
                    CurrentPage = pn,
                    TotalItems = RepoPrc.TotalCount(catname),
                    ItemsPerPage = showpage

                },
                CurrentCategory= catname
            };


            return View(prlvm);
        }

        public IActionResult list(string catname, int pn = 1)
        {
            //?pn=2
            int showpage = 3;
            var pr = RepoPrc.GetProducts(showpage, pn, catname).ToList();

            ProductsListViewModel prlvm = new ProductsListViewModel()
            {
                Products = pr,
                PagingInfo = new Models.Commons.PagingInfo
                {
                    CurrentPage = pn,
                    TotalItems = RepoPrc.TotalCount(catname),
                    ItemsPerPage = showpage

                },
                CurrentCategory = catname
            };


            return View(prlvm);
        }



    }


}
 