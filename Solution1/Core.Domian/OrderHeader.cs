using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domian
{
    public class OrderHeader
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string  Phonenumber   { get; set; }
        //public string Line1 { get; set; }
        public string City { get; set; }
        public string province  { get; set; }
        //public string PaymentId { get; set; }
        //public DateTime? PaymentDate { get; set; }
        //public bool Shipped { get; set; }
       // public bool HasPayment => PaymentDate.HasValue;
        public decimal TotalPrice { get; set; }
    }
}
