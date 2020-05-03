using Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructures.Dal.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BizContext ctx;
        public BaseRepository(BizContext biz)
        {
            ctx = biz;
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return ctx.Set<TEntity>().Find(id);
             
        }

        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>().AsQueryable();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
