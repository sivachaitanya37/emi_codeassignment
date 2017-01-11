using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Factories
{
    public class RepositoryFactory
    {
        public static void RegisterRepository<T, TRepo>()
            where T : ModelBase
            where TRepo : IRepository<T>
        {
        }

        public static IRepository<T> GetRepositor<T>(IDbContext db) where T : ModelBase
        {
            throw new NotImplementedException();
        }

    }
}
