using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ResourceManagement.Core.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : ModelBase
    {
        public IDbContext Db { get; set; }

        public void Add(T ent)
        {
            Db.Set<T>().Add(ent);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T ent)
        {
            throw new NotImplementedException();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public void Update(T ent)
        {
            throw new NotImplementedException();
        }
    }
}
