using EMI_CodeAssignment.Business.Core;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EMI_CodeAssignment.WebApp.Controllers
{
    public class AllocationController : Controller
    {
        private IDataContext db;
        private IRepository<ProjectTask> taskRepo;
        private IRepository<ProjectTaskResource> projectTasksResourcesRepo;
        private IRepository<Resource> resourcesRepo;

        public AllocationController(IDataContext db)
        {
            this.db = db;

            this.taskRepo = RepositoryFactory.GetRepository<ProjectTask>(db);
            this.projectTasksResourcesRepo = RepositoryFactory.GetRepository<ProjectTaskResource>(db);
            this.resourcesRepo = RepositoryFactory.GetRepository<Resource>(db);
        }

        // GET: Allocation
        public async Task<ActionResult> Tasks(Guid? taskId)
        {
            ViewModels.TasksViewModel model = new ViewModels.TasksViewModel();
            model.Tasks = await taskRepo.GetAsync();

            if (taskId.HasValue)
            {
                model.SelectedTask = model.Tasks.Where(t => t.Id == taskId.Value).FirstOrDefault();
                model.Resources = (await projectTasksResourcesRepo.GetAsync()).Where(t => t.TaskId == taskId).ToList();
            }

            return View(model);
        }

        public async Task<ActionResult> Resources(Guid taskId, Guid? resourceId)
        {
            ViewModels.ResourceViewModel model = new ViewModels.ResourceViewModel();
            model.Task = await taskRepo.GetAsync(taskId);
            model.Resources = await resourcesRepo.GetAsync();

            if (resourceId.HasValue)
            {
                model.SelectedResource = model.Resources.Where(t => t.Id == resourceId).FirstOrDefault();
                model.Tasks = (await projectTasksResourcesRepo.GetAsync()).Where(t => t.ResourceId == resourceId).ToList();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Resources(ViewModels.ResourceViewModel model)
        {
            if (model.StartDate > model.EndDate)
            {
                ModelState.AddModelError("", "Start Date should be less than or equals to End Date");
            }
            else
            {
                var resourceTasks = (await projectTasksResourcesRepo.GetAsync()).Where(t => t.ResourceId == model.ResourceId.Value).ToList();
                if (!Helpers.ValidationHelper.ValidateDateRange(resourceTasks, model.StartDate, model.EndDate))
                {
                    ModelState.AddModelError("", "The allocation overlaps with his/her tasks in the specified date range");
                }

                else
                {
                    var taskResources = (await projectTasksResourcesRepo.GetAsync()).Where(t => t.TaskId == model.TaskId.Value).ToList();
                    if (!Helpers.ValidationHelper.ValidateDateRange(taskResources, model.StartDate, model.EndDate))
                    {
                        ModelState.AddModelError("", "Multiple resources overlap working on same task in the specified date range");
                    }
                }
            }


            if (ModelState.IsValid)
            {
                ProjectTaskResource projectTask = new ProjectTaskResource()
                {
                    EndDate = model.EndDate,
                    StartDate = model.StartDate,
                    TaskId = model.TaskId.Value,
                    ResourceId = model.ResourceId.Value
                };

                projectTasksResourcesRepo.Add(projectTask);
                await db.SaveChangesAsync();

                return RedirectToAction("Tasks", new { taskId = model.TaskId });
            }
            else
            {
                model.Task = await taskRepo.GetAsync(model.TaskId.Value);
                model.Resources = await resourcesRepo.GetAsync();

                if (model.ResourceId.HasValue)
                {
                    model.SelectedResource = model.Resources.Where(t => t.Id == model.ResourceId.Value).FirstOrDefault();
                    model.Tasks = (await projectTasksResourcesRepo.GetAsync()).Where(t => t.ResourceId == model.ResourceId.Value).ToList();
                }
            }

            return View(model);
        }


    }
}