using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using EMI_CodeAssignment.Business.Interfaces;

namespace EMI_CodeAssignment.Business.Core
{
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        protected IDataContext db;

        public RepositoryBase(IDataContext db)
        {
            this.db = db;
        }

        public virtual void Add(T ent)
        {
            db.Add(ent);
        }

        public virtual void Delete(T ent)
        {
            db.Delete(ent);
        }

        public virtual void Delete(Guid id)
        {
            var ent = db.GetQuery<T>().Where(t => t.Id == id).FirstOrDefault();
            if (ent == null)
            {
                throw new KeyNotFoundException($"An entity with key - {id} is not found");
            }

            Delete(ent);
        }

        public async virtual Task<List<T>> GetAsync()
        {
            return await db.GetQuery<T>().ToListAsync();
        }

        public async virtual Task<T> GetAsync(Guid id)
        {
            return await db.GetQuery<T>().Where(t => t.Id == id).FirstOrDefaultAsync();
        }

        public virtual void Update(T ent)
        {
            db.Update(ent);
        }
    }
}
