using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contract
{
    public interface IPayment
    {
        RequestPaymentResult RequestPayment(string amount, string mobile, string factorNumber, string description);
        VerifyPayemtnResult VerifyPayment(string token);
    }
}
