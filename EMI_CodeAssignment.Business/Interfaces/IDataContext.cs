using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Interfaces
{
    public interface IDataContext : IDisposable
    {
        IQueryable<T> GetQuery<T>() where T : class;

        void Add<T>(T ent) where T : class;

        void Update<T>(T ent) where T : class;

        void Delete<T>(T ent) where T : class;

        Task<int> SaveChangesAsync();
    }
}
