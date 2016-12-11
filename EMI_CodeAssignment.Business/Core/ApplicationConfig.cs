using EMI_CodeAssignment.Business.Repositories;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Core
{
    public class ApplicationConfig
    {
        public static void Initialize()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
            RepositoryFactory.RegisterRepository<ProjectTask, ProjectTaskRepository>();
            RepositoryFactory.RegisterRepository<ProjectTaskResource, ProjectTaskResourceRepository>();
        }
    }
}
