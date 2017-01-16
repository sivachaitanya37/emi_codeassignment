using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace ResourceManagement.Core.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : ModelBase
    {
        public IDbContext Db { get; set; }
        
        public virtual void Add(T ent)
        {
            Db.Set<T>().Add(ent);
        }

        public virtual void Delete(Guid id)
        {
            var entity = FindById(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity with given key {id} is not found");
            }
            Delete(entity);
        }

        public virtual void Delete(T ent)
        {
            Db.Delete(ent);
        }

        public virtual T FindById(Guid id)
        {
            return Db.GetQuery<T>().Where(item => item.Id == id).FirstOrDefault();
        }

        public async virtual Task<T> FindByIdAsync(Guid id)
        {
            return await Db.GetQuery<T>().Where(item => item.Id == id).FirstOrDefaultAsync();

        }

        public virtual IQueryable<T> GetQuery()
        {
            return Db.GetQuery<T>();
        }

        public virtual void Update(T ent)
        {
            Db.Update(ent);
        }
    }
}
