using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAsync();

        Task<T> GetAsync(Guid id);

        void Add(T ent);

        void Update(T ent);

        void Delete(Guid id);

        void Delete(T ent);
    }
}
