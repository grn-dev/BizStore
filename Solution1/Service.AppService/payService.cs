﻿using Core.Contract;
using Core.Domian;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

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
            HttpClient client = new HttpClient();
            Dictionary<string, string> post_values = new Dictionary<string, string>();

            post_values.Add("api", configuration["PayIr:ApiKey"]);
            post_values.Add("amount", amount.ToString());
            post_values.Add("redirect", configuration["PayIr:RedirectUrl"]);
            post_values.Add("mobile", mobile);
            post_values.Add("factorNumber", factorNumber);
            post_values.Add("description", description);

            var content = new FormUrlEncodedContent(post_values);
            var response = client.PostAsync(configuration["PayIr:SendRequestUrl"], content).Result;

            var responseString = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<RequestPaymentResult>(responseString);


        }

        public VerifyPayemtnResult VerifyPayment(string token)
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> post_values = new Dictionary<string, string>();
            post_values.Add("api", configuration["PayIr:ApiKey"]);
            post_values.Add("token", token);
            var content = new FormUrlEncodedContent(post_values);
            var response = client.PostAsync(configuration["PayIr:VerifyUrl"], content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<VerifyPayemtnResult>(responseString);
        }
    }
}
