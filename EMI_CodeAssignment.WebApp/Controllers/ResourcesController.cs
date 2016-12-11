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
using EMI_CodeAssignment.Business.Database;
using EMI_CodeAssignment.Business.Interfaces;
using EMI_CodeAssignment.Business.Core;

namespace EMI_CodeAssignment.WebApp.Controllers
{
    public class ResourcesController : Controller
    {
        private IDataContext db;
        private IRepository<Resource> repo;
        public ResourcesController(IDataContext db)
        {
            this.db = db;
            this.repo = RepositoryFactory.GetRepository<Resource>(db);
        }

        // GET: Resources
        public async Task<ActionResult> Index()
        {
            return View(await repo.GetAsync());
        }

        // GET: Resources/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = await repo.GetAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }
            return View(resource);
        }

        // GET: Resources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] Resource resource)
        {
            if (ModelState.IsValid)
            {
                resource.Id = Guid.NewGuid();
                repo.Add(resource);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(resource);
        }
        // GET: ProjectTasks/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            Resource resource = await repo.GetAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }

            return View(resource);
        }


        // POST: Resources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] Resource resource)
        {
            if (ModelState.IsValid)
            {
                repo.Update(resource);

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(resource);
        }

        // GET: Resources/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = await repo.GetAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }
            return View(resource);
        }

        // POST: Resources/Delete/5
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
