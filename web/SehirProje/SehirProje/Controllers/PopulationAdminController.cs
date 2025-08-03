using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SehirProje.Models;

namespace SehirProje.Controllers
{
    [Authorize(Roles = "admin")]
    public class PopulationAdminController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: PopulationAdmin
        public ActionResult Index()
        {
            return View(db.populations.ToList());
        }

        // GET: PopulationAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            populations populations = db.populations.Find(id);
            if (populations == null)
            {
                return HttpNotFound();
            }
            return View(populations);
        }

        // GET: PopulationAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PopulationAdmin/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,year,count")] populations populations)
        {
            if (ModelState.IsValid)
            {
                db.populations.Add(populations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(populations);
        }

        // GET: PopulationAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            populations populations = db.populations.Find(id);
            if (populations == null)
            {
                return HttpNotFound();
            }
            return View(populations);
        }

        // POST: PopulationAdmin/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,year,count")] populations populations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(populations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(populations);
        }

        // GET: PopulationAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            populations populations = db.populations.Find(id);
            if (populations == null)
            {
                return HttpNotFound();
            }
            return View(populations);
        }

        // POST: PopulationAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            populations populations = db.populations.Find(id);
            db.populations.Remove(populations);
            db.SaveChanges();
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
