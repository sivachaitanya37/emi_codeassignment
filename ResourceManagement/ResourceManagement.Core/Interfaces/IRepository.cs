using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces

{
    public interface IRepository<T> where T : ModelBase
    {
        IDbContext Db { get; set; }
        void Add(T ent);

        void Update(T ent);

        void Delete(T ent);

        void Delete(Guid id);

        T FindById(Guid id);

        Task<T> FindByIdAsync(Guid id);

        IQueryable<T> GetQuery();
    }
}
