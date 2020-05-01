using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domian
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        ///
        public int ParentId { get; set; }
        public Category Parent { get; set; }
    }
}
