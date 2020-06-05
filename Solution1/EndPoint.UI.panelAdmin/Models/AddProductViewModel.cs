using Core.Domian;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.UI.panelAdmin.Models
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public List<Category> CategoryForDisplay { get; set; }
    }
}
