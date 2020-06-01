using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using EndPoints.WebUI.Models.Producte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoints.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public string categori_name { get; set; }
        private readonly ICategoriRepo CategoryRepo;
        private readonly IPruductRepo RepoPrc;
        public CategoryController(ICategoriRepo ctx, IPruductRepo pruduct)
        {
            CategoryRepo = ctx;
            RepoPrc = pruduct;
        }
        // GET: /<controller>/
        public IActionResult Index(string category)
        {
            if (category != null)
            {
                categori_name = category;
            }
             
            int showpage = 3;
            return RedirectToAction("Index", "Prouduct", new { @catname = categori_name, @pn=1 }); 
             
        }


        //[HttpGet]
        //[Route("{catname}/PageR{pn:int}")]
        //[Route("{catname}/PageR{pn:int}")]
        public IActionResult list(string catname2, int pn = 1)
        {
            //?pn=2
            int showpage = 19;
            var pr = RepoPrc.GetProducts(showpage, pn, catname2).ToList();

            ProductsListViewModel prlvm = new ProductsListViewModel()
            {
                Products = pr,
                PagingInfo = new Models.Commons.PagingInfo
                {
                    CurrentPage = pn,
                    TotalItems = RepoPrc.TotalCount(catname2),
                    ItemsPerPage = showpage

                },
                CurrentCategory = catname2
            };


            return View(prlvm);
        }
    }
}
