using EMI_CodeAssignment.Business.Database;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Core
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<EMI_CodeAssignmentDb>
    {
        protected override void Seed(EMI_CodeAssignmentDb context)
        {
            #region Resource

            Resource res = new Resource();
            res.Name = "Leana Weatherly";
            context.Resources.Add(res);

            res = new Resource();
            res.Name = "Dewey Parman";
            context.Resources.Add(res);

            Resource resource3 = new Resource();
            resource3.Name = "Valentine Frigo";
            context.Resources.Add(resource3);

            Resource resource4 = new Resource();
            resource4.Name = "Rocco Tien";
            context.Resources.Add(resource4);
            Resource resource5 = new Resource();
            resource5.Name = "Carmelita Whitefield";
            context.Resources.Add(resource5);
            Resource resource6 = new Resource();
            resource6.Name = "Dannette Winsett";
            context.Resources.Add(resource6);
            Resource resource7 = new Resource();
            resource7.Name = "DaciaWiren";
            context.Resources.Add(resource7);
            Resource resource8 = new Resource();
            resource8.Name = "Clora Leanos";
            context.Resources.Add(resource8);
            Resource resource9 = new Resource();
            resource9.Name = "Tawnya Whitlock";
            context.Resources.Add(resource9);
            Resource resource10 = new Resource();
            resource10.Name = "Louise Galley";
            context.Resources.Add(resource10);
            Resource resource11 = new Resource();
            resource11.Name = "Cathy Kestner";
            context.Resources.Add(resource11);
            Resource resource12 = new Resource();
            resource12.Name = "Leonia Carino";
            context.Resources.Add(resource12);
            Resource resource13 = new Resource();
            resource13.Name = "Hector Lichty";
            context.Resources.Add(resource13);
            Resource resource14 = new Resource();
            resource14.Name = "Gabriel Wikoff";
            context.Resources.Add(resource14);
            Resource resource15 = new Resource();
            resource15.Name = "Herschel Pardue";
            context.Resources.Add(resource15);
            Resource resource16 = new Resource();
            resource16.Name = "Gerda Wyant";
            context.Resources.Add(resource16);
            Resource resource17 = new Resource();
            resource17.Name = "Ralph Bartell";
            context.Resources.Add(resource17);
            Resource resource18 = new Resource();
            resource18.Name = "Harley Lauer";
            context.Resources.Add(resource18);
            Resource resource19 = new Resource();
            resource19.Name = "Lawrence Hoosier";
            context.Resources.Add(resource19);
            Resource resource20 = new Resource();
            resource20.Name = "Lana Sechrist";
            context.Resources.Add(resource20);
            #endregion

            #region ProjectTask Feed
            ProjectTask Tasks1 = new ProjectTask(); Tasks1.Name = "Tasks1"; Tasks1.StartDate = DateTime.Parse("1-Jan-15"); Tasks1.EndDate = DateTime.Parse("7-Jan-15"); context.ProjectTasks.Add(Tasks1);
            ProjectTask Tasks2 = new ProjectTask(); Tasks2.Name = "Tasks2"; Tasks2.StartDate = DateTime.Parse("1-Jan-15"); Tasks2.EndDate = DateTime.Parse("4-Jan-15"); context.ProjectTasks.Add(Tasks2);
            ProjectTask Tasks3 = new ProjectTask(); Tasks3.Name = "Tasks3"; Tasks3.StartDate = DateTime.Parse("1-Jan-15"); Tasks3.EndDate = DateTime.Parse("4-Jan-15"); context.ProjectTasks.Add(Tasks3);
            ProjectTask Tasks4 = new ProjectTask(); Tasks4.Name = "Tasks4"; Tasks4.StartDate = DateTime.Parse("3-Jan-15"); Tasks4.EndDate = DateTime.Parse("6-Jan-15"); context.ProjectTasks.Add(Tasks4);
            ProjectTask Tasks5 = new ProjectTask(); Tasks5.Name = "Tasks5"; Tasks5.StartDate = DateTime.Parse("5-Jan-15"); Tasks5.EndDate = DateTime.Parse("8-Jan-15"); context.ProjectTasks.Add(Tasks5);
            ProjectTask Tasks6 = new ProjectTask(); Tasks6.Name = "Tasks6"; Tasks6.StartDate = DateTime.Parse("6-Jan-15"); Tasks6.EndDate = DateTime.Parse("9-Jan-15"); context.ProjectTasks.Add(Tasks6);
            ProjectTask Tasks7 = new ProjectTask(); Tasks7.Name = "Tasks7"; Tasks7.StartDate = DateTime.Parse("10-Jan-15"); Tasks7.EndDate = DateTime.Parse("13-Jan-15"); context.ProjectTasks.Add(Tasks7);
            ProjectTask Tasks8 = new ProjectTask(); Tasks8.Name = "Tasks8"; Tasks8.StartDate = DateTime.Parse("31-Dec-14"); Tasks8.EndDate = DateTime.Parse("1-Jan-15"); context.ProjectTasks.Add(Tasks8);
            ProjectTask Tasks9 = new ProjectTask(); Tasks9.Name = "Tasks9"; Tasks9.StartDate = DateTime.Parse("31-Dec-14"); Tasks9.EndDate = DateTime.Parse("1-Jan-15"); context.ProjectTasks.Add(Tasks9);
            ProjectTask Tasks10 = new ProjectTask(); Tasks10.Name = "Tasks10"; Tasks10.StartDate = DateTime.Parse("3-Jan-15"); Tasks10.EndDate = DateTime.Parse("4-Jan-15"); context.ProjectTasks.Add(Tasks10);
            ProjectTask Tasks11 = new ProjectTask(); Tasks11.Name = "Tasks11"; Tasks11.StartDate = DateTime.Parse("8-Jan-15"); Tasks11.EndDate = DateTime.Parse("9-Jan-15"); context.ProjectTasks.Add(Tasks11);
            ProjectTask Tasks12 = new ProjectTask(); Tasks12.Name = "Tasks12"; Tasks12.StartDate = DateTime.Parse("13-Jan-15"); Tasks12.EndDate = DateTime.Parse("22-Jan-15"); context.ProjectTasks.Add(Tasks12);
            ProjectTask Tasks13 = new ProjectTask(); Tasks13.Name = "Tasks13"; Tasks13.StartDate = DateTime.Parse("31-Dec-14"); Tasks13.EndDate = DateTime.Parse("9-Jan-15"); context.ProjectTasks.Add(Tasks13);
            ProjectTask Tasks14 = new ProjectTask(); Tasks14.Name = "Tasks14"; Tasks14.StartDate = DateTime.Parse("31-Dec-14"); Tasks14.EndDate = DateTime.Parse("9-Jan-15"); context.ProjectTasks.Add(Tasks14);
            ProjectTask Tasks15 = new ProjectTask(); Tasks15.Name = "Tasks15"; Tasks15.StartDate = DateTime.Parse("3-Jan-15"); Tasks15.EndDate = DateTime.Parse("12-Jan-15"); context.ProjectTasks.Add(Tasks15);
            ProjectTask Tasks16 = new ProjectTask(); Tasks16.Name = "Tasks16"; Tasks16.StartDate = DateTime.Parse("8-Jan-15"); Tasks16.EndDate = DateTime.Parse("11-Jan-15"); context.ProjectTasks.Add(Tasks16);
            ProjectTask Tasks17 = new ProjectTask(); Tasks17.Name = "Tasks17"; Tasks17.StartDate = DateTime.Parse("13-Jan-15"); Tasks17.EndDate = DateTime.Parse("16-Jan-15"); context.ProjectTasks.Add(Tasks17);
            ProjectTask Tasks18 = new ProjectTask(); Tasks18.Name = "Tasks18"; Tasks18.StartDate = DateTime.Parse("31-Dec-14"); Tasks18.EndDate = DateTime.Parse("3-Jan-15"); context.ProjectTasks.Add(Tasks18);
            ProjectTask Tasks19 = new ProjectTask(); Tasks19.Name = "Tasks19"; Tasks19.StartDate = DateTime.Parse("31-Dec-14"); Tasks19.EndDate = DateTime.Parse("9-Jan-15"); context.ProjectTasks.Add(Tasks19);
            ProjectTask Tasks20 = new ProjectTask(); Tasks20.Name = "Tasks20"; Tasks20.StartDate = DateTime.Parse("3-Jan-15"); Tasks20.EndDate = DateTime.Parse("12-Jan-15"); context.ProjectTasks.Add(Tasks20);
            #endregion

            base.Seed(context);
        }
    }
}
