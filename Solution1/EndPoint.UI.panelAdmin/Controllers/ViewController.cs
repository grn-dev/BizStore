using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.UI.panelAdmin.Controllers
{
    [Authorize]
    public class ViewController : Controller
    {

        private readonly IOrderRepo orderRepository;
        public ViewController(IOrderRepo orderRepository_)
        {
            orderRepository = orderRepository_;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAllOrder()
        {
            var result = orderRepository.Search(false);
            return View(result);
            //paymentID
        }

        public IActionResult ViewOrderPaid()
        {
            var result = orderRepository.Search(true);
            return View("ViewAllOrder", result);
            //return View(result);
            //paymentID
        }


        public IActionResult ViewDetail(int id)
        {
            var order = orderRepository.GetWithOrderLine(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }


        [HttpPost]
        public IActionResult Ship(int id)
        {
            var order = orderRepository.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            orderRepository.Ship(id);
            return RedirectToAction(nameof(ViewAllOrder));
        }

    }
}