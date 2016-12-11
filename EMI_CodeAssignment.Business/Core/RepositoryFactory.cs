using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Core
{
    public class RepositoryFactory
    {
        static Dictionary<Type, Type> repositoryTypesStore = new Dictionary<Type, Type>();

        public static void RegisterRepository<TEnt, TRep>() where TEnt : class where TRep : IRepository<TEnt>
        {
            repositoryTypesStore.Add(typeof(TEnt), typeof(TRep));
        }

        public static IRepository<TEnt> GetRepository<TEnt>(IDataContext db) where TEnt : EntityBase
        {
            IRepository<TEnt> repo = null;

            if (repositoryTypesStore.ContainsKey(typeof(TEnt)))
            {
                repo = Activator.CreateInstance(repositoryTypesStore[typeof(TEnt)], db) as IRepository<TEnt>;
            }
            else
            {
                repo = Activator.CreateInstance(typeof(RepositoryBase<TEnt>), db) as IRepository<TEnt>;
            }

            return repo;
        }
    }
}
