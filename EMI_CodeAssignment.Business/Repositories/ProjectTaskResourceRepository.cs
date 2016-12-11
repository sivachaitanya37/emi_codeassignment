using EMI_CodeAssignment.Business.Core;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EMI_CodeAssignment.Business.Repositories
{
    public class ProjectTaskResourceRepository : RepositoryBase<ProjectTaskResource>
    {
        public ProjectTaskResourceRepository(IDataContext db)
            : base(db)
        {

        }

        public override Task<List<ProjectTaskResource>> GetAsync()
        {
            return db.GetQuery<ProjectTaskResource>().Include(t => t.Resource).Include(t => t.Task).ToListAsync();
        }
    }
}
