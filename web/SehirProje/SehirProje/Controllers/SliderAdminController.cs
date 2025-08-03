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
    public class SliderAdminController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: SliderAdmin
        public ActionResult Index()
        {
            return View(db.slider_images.ToList());
        }

        // GET: SliderAdmin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            slider_images slider_images = db.slider_images.Find(id);
            if (slider_images == null)
            {
                return HttpNotFound();
            }
            return View(slider_images);
        }

        // GET: SliderAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SliderAdmin/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,image_url,image_text")] slider_images slider_images)
        {
            if (ModelState.IsValid)
            {
                db.slider_images.Add(slider_images);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(slider_images);
        }

        // GET: SliderAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            slider_images slider_images = db.slider_images.Find(id);
            if (slider_images == null)
            {
                return HttpNotFound();
            }
            return View(slider_images);
        }

        // POST: SliderAdmin/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,image_url,image_text")] slider_images slider_images)
        {
            if (ModelState.IsValid)
            {
                db.Entry(slider_images).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(slider_images);
        }

        // GET: SliderAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            slider_images slider_images = db.slider_images.Find(id);
            if (slider_images == null)
            {
                return HttpNotFound();
            }
            return View(slider_images);
        }

        // POST: SliderAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            slider_images slider_images = db.slider_images.Find(id);
            db.slider_images.Remove(slider_images);
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
