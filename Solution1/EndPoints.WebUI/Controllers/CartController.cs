using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using EndPoints.WebUI.Models.Carts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using EndPoints.WebUI.Infrastructures;
using EndPoints.WebUI.Models.Carts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EndPoints.WebUI.Controllers
{
    public class CartController : Controller
    {
        // GET: /<controller>/

        private IPruductRepo repository;
         private Cart _cart;

        public CartController(IPruductRepo repo , Cart cart)
        {
            repository = repo;
            _cart = cart;
        }
        public ViewResult Index()
        {
            return View(new CartIndexViewModel
            {
                //Cart = GetCart(),
                Cart = _cart
            });

        }
        [HttpPost]
        public RedirectToActionResult AddToCart(int productId)// , string returnUrl)
        {
            var returnUrl = "Prouduct";

            Product product = repository.Get(productId);
            if (product != null)
            {
                _cart.AddItem(product, 1);
                //Cart cart = GetCart();
                //cart.AddItem(product, 1);
                //savecart(cart);
            }
            return RedirectToAction("Index", "Prouduct", new { });
        }
        public RedirectToActionResult RemoveFromCart(int productId,
        string returnUrl)
        {
            Product product = repository.Get(productId);
            if (product != null)
            {
                _cart.RemoveLine(product);
                //Cart cart = GetCart();
                //cart.RemoveLine(product);
                //savecart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }



        private Cart GetCart()
        {
            Cart crt = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            return crt;
        }


        private void savecart(Cart cart)
        {
            HttpContext.Session.SetJson("cart", cart);

        }



    }

}
