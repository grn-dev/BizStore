using Core.Domian;
using System;
using Core.Contract;
using System.Collections.Generic;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepo
    {
        private readonly BizContext ctx;
        public OrderRepository(BizContext dbContext) : base(dbContext)
        {
            ctx = dbContext;
        }
    }
}
