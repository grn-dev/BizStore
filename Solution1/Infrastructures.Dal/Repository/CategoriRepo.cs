using Core.Contract;
using Core.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class CategoriRepo : BaseRepository<Category>, ICategoriRepo
    {
        private readonly BizContext ctx;
        public CategoriRepo(BizContext dbContext) : base(dbContext)
        {
            ctx = dbContext;
        }

        public Category GetByName(string catname)
        {
            return ctx.Categories.FirstOrDefault(c=> c.CategoryName==catname );
            
        }
    }
}
