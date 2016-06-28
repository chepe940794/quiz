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
    public class ExpModelsController : Controller
    {
        private ExpDbContext db = new ExpDbContext();

        // GET: ExpModels
        public ActionResult Index()
        {
            return View(db.ExpModels.ToList());
        }

        // GET: ExpModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpModel expModel = db.ExpModels.Find(id);
            if (expModel == null)
            {
                return HttpNotFound();
            }
            return View(expModel);
        }

        // GET: ExpModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Oficio,Empresa,Exp,Trabajo")] ExpModel expModel)
        {
            if (ModelState.IsValid)
            {
                db.ExpModels.Add(expModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expModel);
        }

        // GET: ExpModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpModel expModel = db.ExpModels.Find(id);
            if (expModel == null)
            {
                return HttpNotFound();
            }
            return View(expModel);
        }

        // POST: ExpModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Oficio,Empresa,Exp,Trabajo")] ExpModel expModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expModel);
        }

        // GET: ExpModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpModel expModel = db.ExpModels.Find(id);
            if (expModel == null)
            {
                return HttpNotFound();
            }
            return View(expModel);
        }

        // POST: ExpModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpModel expModel = db.ExpModels.Find(id);
            db.ExpModels.Remove(expModel);
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
