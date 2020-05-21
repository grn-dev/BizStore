using Core.Contract;
using Core.Domian;
using Microsoft.Extensions.Configuration;
using System; 

namespace Service.AppService
{
    public class payService : IPayment
    {

        private readonly IConfiguration configuration;

        public payService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public RequestPaymentResult RequestPayment(string amount, string mobile, string factorNumber, string description)
        {
            throw new NotImplementedException();
        }

        public VerifyPayemtnResult VerifyPayment(string token)
        {
            throw new NotImplementedException();
        }
    }
}
