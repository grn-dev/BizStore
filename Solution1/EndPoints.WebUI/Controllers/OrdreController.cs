using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using Microsoft.AspNetCore.Mvc;

namespace EndPoints.WebUI.Controllers
{
    public class OrdreController : Controller
    {
        private IOrderRepo repository;
        private Cart cart;
        public OrdreController(IOrderRepo repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public ViewResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                //TempData["OrderId"] = order.OrderID;
                //TempData["Price"] = order.Lines.Sum(c => c.Product.Price * c.Quantity);
                return RedirectToAction(nameof(Completed), new { Id = order.OrderID });
            }
            else
            {
                return View(order);
            }
        }
        public IActionResult Completed(int id)
        {
            var order = repository.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }
}