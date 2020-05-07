using Core.Contract;
using Core.Domian;

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructures.Dal.Repository
{
    public class ProductRepository: BaseRepository<Product>, IPruductRepo
    {
        private readonly BizContext ctx;
        public ProductRepository(BizContext dbContext) : base(dbContext)
        {
            ctx = dbContext;
        }

        
         
        public List<Product> GetProducts(int pageSize = 4, int pageNumber = 1)
        {
            return ctx.Products.Include(c => c.Category).Skip(pageSize*(pageNumber-1)).Take(pageSize).ToList();
        }

        public int TotalCount()//page/4 ,categori
        {
            return ctx.Products.Count();
        }

        //public int TotalCount(string category)
        //{
        //    throw new NotImplementedException();
        //}
    }
     
}
