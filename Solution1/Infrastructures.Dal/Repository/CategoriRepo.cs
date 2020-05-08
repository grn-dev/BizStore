using Core.Contract;
using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class CategoriRepo : BaseRepository<Category>, ICategoriRepo
    {
        public CategoriRepo(BizContext dbContext) : base(dbContext)
        {

        }
    }
}
