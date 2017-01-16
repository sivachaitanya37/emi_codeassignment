using ResourceManagement.Core.Interfaces;
using ResourceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using ResourceManagement.Core.Services;

namespace ResourceManagement.Core.Factories
{
    public class RepositoryFactory
    {
        static UnityContainer container = new UnityContainer();

        public static void RegisterRepository<TEntity, TRepository>()
            where TEntity : ModelBase
            where TRepository : IRepository<TEntity>
        {
            container.RegisterType(typeof(TEntity), typeof(TRepository), new TransientLifetimeManager());
        }

        public static IRepository<TEntity> GetRepositor<TEntity>(IDbContext db)
            where TEntity : ModelBase
        {
            IRepository<TEntity> requiredRepository = container.Resolve<TEntity>() as IRepository<TEntity>;

            if (requiredRepository == null)
            {
                requiredRepository = Activator.CreateInstance(typeof(RepositoryBase<TEntity>), db)
                    as IRepository<TEntity>;
            }

            requiredRepository.Db = db;
            return requiredRepository;
        }

    }
}
