using Core.Contract;
using Core.Domian;
using Core.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class ProductRepository: BaseRepository<Product>, IPruductRepo
    {
        public ProductRepository(BizContext dbContext) : base(dbContext)
        {

        }

        public int TotalCount(string category)
        {
            throw new NotImplementedException();
        }
    }
     
}
