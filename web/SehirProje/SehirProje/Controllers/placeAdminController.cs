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
    public class placeAdminController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: placeAdmin
        public ActionResult Index()
        {
            return View(db.places.ToList());
        }

        // GET: placeAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            places places = db.places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // GET: placeAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: placeAdmin/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,place_name")] places places)
        {
            if (ModelState.IsValid)
            {
                db.places.Add(places);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(places);
        }

        // GET: placeAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            places places = db.places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // POST: placeAdmin/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,place_name")] places places)
        {
            if (ModelState.IsValid)
            {
                db.Entry(places).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(places);
        }

        // GET: placeAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            places places = db.places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // POST: placeAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            places places = db.places.Find(id);
            db.places.Remove(places);
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
