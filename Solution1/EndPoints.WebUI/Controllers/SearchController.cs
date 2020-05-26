using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using EndPoints.WebUI.Models.Commons;
using EndPoints.WebUI.Models.Search;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.WebUI.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPruductRepo RepoPrc;
        public SearchController(IPruductRepo pruduct)
        {
            RepoPrc = pruduct;
        }

         
         
        public IActionResult searchByname(string prcname,int pn=1)
        {
            //?pn=2
            int showpage = 3;
            var Allprbysearch = RepoPrc.GetProductsSearch(showpage, pn, prcname).ToList();
             

            SeachViewModel SeachView = new SeachViewModel()
            {
                Products = Allprbysearch,

                PagingInfo = new Models.Commons.SearchPagingInfo
                {
                    CurrentPage = pn,
                    TotalItems = RepoPrc.TotalCountSearch(prcname),
                    ItemsPerPage = showpage,
                    CurrentSreach= prcname

                },
                
            };


            return View(SeachView);
            //return View("sabaliiiiii");
             
        }

        public IActionResult tranfer(string prcname, int pn = 1)
        {

            return RedirectToAction("searchByname", new { prcname = prcname });

        }

    }
}