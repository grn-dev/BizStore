using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contract;
using Core.Domian;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EndPoints.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IOrderRepo orderRepository;
        private readonly IPayment payment;
        private readonly IConfiguration configuration;
        public PaymentController(IOrderRepo orderRepository, IPayment payment, IConfiguration configuration)
        {
            this.orderRepository = orderRepository;
            this.payment = payment;
            this.configuration = configuration;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult RequestPayment(int orderId)
        {
            var order = orderRepository.GetWithOrderLine(orderId);
            //order.Phonenumber
            var result = payment.RequestPayment(order.Lines.Sum(c => c.Product.Price).ToString(), "09210956832", order.OrderID.ToString(), $"Description {order.Name}");
            if (result.IsCorrect)
            {
                orderRepository.SetTransactionId(orderId, result.Token);
                return Redirect($"{configuration["PayIr:PaymentUrl"]}{result.Token}");
            }
            return View("PaymentError", result);
        }

        //post
        public IActionResult Verify(PaymentResult result)
        {
            if (result.IsCorrect)
            {
                var verifyResult = payment.VerifyPayment(result.Token.ToString());
                if (verifyResult.IsCorrect)
                {
                    orderRepository.SetPaymentDone(verifyResult.factorNumber);
                    return View("PaymentCompelete", verifyResult);
                }


            }
            return View("PaymentError", result);

        }
    }
}