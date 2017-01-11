using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Interfaces
{
    public interface IDbContext
    {
        IQueryable<T> GetQuery<T>() where T : class;

        DbSet<T> Set<T>() where T : class;

        void Update<T>(T ent) where T : class;

        void Delete<T>(T ent) where T : class;

        int SaveChanges();
    }
}
