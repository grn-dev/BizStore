using Infrastructures.Dal.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoints.WebUI.Models.Categories;

namespace EndPoints.WebUI.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private readonly CategoriRepo _categoryRepository;

        public NavigationMenuViewComponent(CategoriRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var model = new NavigationMenuViewModel
            {
                Categories = _categoryRepository.GetAll().ToList(),

            };
            if (RouteData?.Values.ContainsKey("category") == true)
            {
                model.CurentCategory = RouteData.Values["category"].ToString();
            }
            return View(model);
        }
    }
}
