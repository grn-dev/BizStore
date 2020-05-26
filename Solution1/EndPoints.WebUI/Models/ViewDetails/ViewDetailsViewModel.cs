using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoints.WebUI.Models.ViewDetails
{
    public class ViewDetailsViewModel
    {
        public Product MainProduct { get; set; }
        public List<Product> ReletionProduct { get; set; }
    }
}
