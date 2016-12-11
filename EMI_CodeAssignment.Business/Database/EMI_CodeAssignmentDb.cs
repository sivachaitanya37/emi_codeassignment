using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Database
{
    public class EMI_CodeAssignmentDb : DbContext, IDataContext
    {
        public DbSet<Resource> Resources { get; set; }

        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<ProjectTaskResource> ProjectTaskResources { get; set; }

        public IQueryable<T> GetQuery<T>() where T : class
        {
            return Set<T>();
        }

        public void Add<T>(T ent) where T : class
        {
            Set<T>().Add(ent);
        }

        public void Update<T>(T ent) where T : class
        {
            Entry(ent).State = EntityState.Modified;
        }

        public void Delete<T>(T ent) where T : class
        {
            Set<T>().Remove(ent);
        }
    }
}
