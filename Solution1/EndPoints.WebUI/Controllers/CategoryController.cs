using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoints.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public string categori_name { get; set; }
        private readonly ICategoriRepo CategoryRepo;
        public CategoryController(ICategoriRepo ctx)
        {
            CategoryRepo = ctx;
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
    }
}
