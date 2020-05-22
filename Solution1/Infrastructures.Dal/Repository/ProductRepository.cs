using Core.Contract;
using Core.Domian;

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructures.Dal.Repository
{
    public class ProductRepository : BaseRepository<Product>, IPruductRepo
    {
        private readonly BizContext ctx;
        public ProductRepository(BizContext dbContext) : base(dbContext)
        {
            ctx = dbContext;
        }

        public List<Product> GetProducts(int pageSize = 4, int pageNumber = 1, string category = null)
        {
            return ctx.Products.
                Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).
                Include(c => c.Category).
                Skip(pageSize * (pageNumber - 1)).
                Take(pageSize).ToList();

        }

        public List<Product> searchByname(string name)
        {
            return ctx.Products.Where(c=> c.Name.Contains(name)).ToList();
        }

        public int TotalCount(string category = null)//page/4 ,categori
        {
            return ctx.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).Count();
        }

        //public int TotalCount(string category)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
