using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domian
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
