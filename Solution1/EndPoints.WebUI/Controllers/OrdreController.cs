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
        public ViewResult index()
        {
            return View(new Order()
            { 
                City="niavaran",
                province="milan",
                //Lines= cart.Lines.ToArray(),
                Email="mahmoudsazbali@gmail.com",
                Addres2 = "afsarinihe,20met",
                Addres ="afsarinihe,20metri prlak",
                lasteName="haj mahmoud",
                Phonenumber="09121212123"
                
            });
        }

        [HttpPost]
        public IActionResult index(Order order)
        {
            order.PaymentId = "";

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
                //mihater
                var errors = ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList();
                return View(order);
            }
        }
        public IActionResult Completed(int id)
        {
            //TODO Bank
            //SHOW ORDER
            var order = repository.GetWithOrderLine(id);
            if (order == null)
            {
                return NotFound();
            }
            //return View(order);
            return View(order);
        }
    }
}