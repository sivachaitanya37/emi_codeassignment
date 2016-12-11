using EMI_CodeAssignment.Business.Core;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Repositories
{
    public class ProjectTaskRepository : RepositoryBase<ProjectTask>
    {
        public ProjectTaskRepository(IDataContext db)
            : base(db)
        {

        }

        public override Task<List<ProjectTask>> GetAsync()
        {
            return db.GetQuery<ProjectTask>().OrderBy(t => t.Name).ToListAsync();
        }

        public override void Add(ProjectTask ent)
        {
            if (ent.StartDate < ent.EndDate)
            {
                throw new Exception("Start date cannot be lesser than End date");
            }

            base.Add(ent);
        }
    }
}
