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
    public class DistrictAdminController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: districtAdmin
        public ActionResult Index()
        {
            return View(db.districts.ToList());
        }

        // GET: districtAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            districts districts = db.districts.Find(id);
            if (districts == null)
            {
                return HttpNotFound();
            }
            return View(districts);
        }

        // GET: districtAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: districtAdmin/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,district_name")] districts districts)
        {
            if (ModelState.IsValid)
            {
                db.districts.Add(districts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(districts);
        }

        // GET: districtAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            districts districts = db.districts.Find(id);
            if (districts == null)
            {
                return HttpNotFound();
            }
            return View(districts);
        }

        // POST: districtAdmin/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,district_name")] districts districts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(districts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(districts);
        }

        // GET: districtAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            districts districts = db.districts.Find(id);
            if (districts == null)
            {
                return HttpNotFound();
            }
            return View(districts);
        }

        // POST: districtAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            districts districts = db.districts.Find(id);
            db.districts.Remove(districts);
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
