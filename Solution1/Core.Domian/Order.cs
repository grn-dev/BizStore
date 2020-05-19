using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domian
{
    public class Order
    {
        public int OrderID { get; set; }
       
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
         

        [Required(ErrorMessage = "Please enter the lasteName line")]
        public string lasteName { get; set; }
        

        [Required(ErrorMessage = "لطفا شماره همراه را وارد نمایید")]
        public string Phonenumber { get; set; }
        

        [Required(ErrorMessage = "لطفا ایمیل را وارد نمایید")]
        public string Email { get; set; }
        

        [Required(ErrorMessage = "Please enter a state name")]
        public string City { get; set; }
        

        public string province { get; set; }

        [Required(ErrorMessage = "Please enter a Addres name")]
        public string Addres { get; set; }
        


        [Required(ErrorMessage = "Please enter a Addres 2 name")]
        public string Addres2 { get; set; }
        

        //public string Zip { get; set; }
        //[Required(ErrorMessage = "Please enter a country name")]

        //public string Country { get; set; }

        //public bool GiftWrap { get; set; }

        public string PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Shipped { get; set; }
    }
}
