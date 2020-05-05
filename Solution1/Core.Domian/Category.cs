using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domian
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
         
        //public int? parentId { get; set; }
        //public Category Parent { get; set; }
        //public List<Category> Childeren { get; set; }
    }
}
