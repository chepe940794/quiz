using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quizz.Models;

namespace Quizz.Controllers
{
    public class LenguajeModelsController : Controller
    {
        private ExpDbContext db = new ExpDbContext();

        // GET: LenguajeModels
        public ActionResult Index()
        {
            return View(db.LenguajeModels.ToList());
        }

        // GET: LenguajeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LenguajeModel lenguajeModel = db.LenguajeModels.Find(id);
            if (lenguajeModel == null)
            {
                return HttpNotFound();
            }
            return View(lenguajeModel);
        }

        // GET: LenguajeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LenguajeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Lenguaje")] LenguajeModel lenguajeModel)
        {
            if (ModelState.IsValid)
            {
                db.LenguajeModels.Add(lenguajeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lenguajeModel);
        }

        // GET: LenguajeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LenguajeModel lenguajeModel = db.LenguajeModels.Find(id);
            if (lenguajeModel == null)
            {
                return HttpNotFound();
            }
            return View(lenguajeModel);
        }

        // POST: LenguajeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lenguaje")] LenguajeModel lenguajeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lenguajeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lenguajeModel);
        }

        // GET: LenguajeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LenguajeModel lenguajeModel = db.LenguajeModels.Find(id);
            if (lenguajeModel == null)
            {
                return HttpNotFound();
            }
            return View(lenguajeModel);
        }

        // POST: LenguajeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LenguajeModel lenguajeModel = db.LenguajeModels.Find(id);
            db.LenguajeModels.Remove(lenguajeModel);
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
