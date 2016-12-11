using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EMI_CodeAssignment.Business;
using EMI_CodeAssignment.Entities;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Business.Core;

namespace EMI_CodeAssignment.WebApp.Controllers
{
    public class ProjectTasksController : Controller
    {
        private IDataContext db;
        private IRepository<ProjectTask> repo;

        public ProjectTasksController(IDataContext db)
        {
            this.db = db;
            this.repo = RepositoryFactory.GetRepository<ProjectTask>(db);
        }

        // GET: ProjectTasks
        public async Task<ActionResult> Index()
        {
            return View(await repo.GetAsync());
        }

        // GET: ProjectTasks/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            ProjectTask projectTask = await repo.GetAsync(id);
            if (projectTask == null)
            {
                return HttpNotFound();
            }

            return View(projectTask);
        }

        // GET: ProjectTasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StartDate,EndDate,Description")] ProjectTask projectTask)
        {
            if (ModelState.IsValid)
            {
                repo.Add(projectTask);
                await db.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(projectTask);
        }

        // GET: ProjectTasks/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            ProjectTask projectTask = await repo.GetAsync(id);
            if (projectTask == null)
            {
                return HttpNotFound();
            }

            return View(projectTask);
        }

        // POST: ProjectTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,StartDate,EndDate,Description,Version")] ProjectTask projectTask)
        {
            if (ModelState.IsValid)
            {
                repo.Update(projectTask);
                await db.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(projectTask);
        }

        // GET: ProjectTasks/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            ProjectTask projectTask = await repo.GetAsync(id);
            if (projectTask == null)
            {
                return HttpNotFound();
            }

            return View(projectTask);
        }

        // POST: ProjectTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            repo.Delete(id);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
