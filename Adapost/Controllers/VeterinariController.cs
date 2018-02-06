using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Adapost.DAL;
using Adapost.Models;

namespace Adapost.Controllers
{
    public class VeterinariController : Controller
    {
        private AdapostContext db = new AdapostContext();

        // GET: Veterinari
        public ActionResult Index()
        {
            return View(db.Veterinari.ToList());
        }

        // GET: Veterinari/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinari veterinari = db.Veterinari.Find(id);
            if (veterinari == null)
            {
                return HttpNotFound();
            }
            return View(veterinari);
        }

        // GET: Veterinari/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veterinari/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVeterinar,Nume,Prenume")] Veterinari veterinari)
        {
            if (ModelState.IsValid)
            {
                db.Veterinari.Add(veterinari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veterinari);
        }

        // GET: Veterinari/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinari veterinari = db.Veterinari.Find(id);
            if (veterinari == null)
            {
                return HttpNotFound();
            }
            return View(veterinari);
        }

        // POST: Veterinari/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVeterinar,Nume,Prenume")] Veterinari veterinari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veterinari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinari);
        }

        // GET: Veterinari/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinari veterinari = db.Veterinari.Find(id);
            if (veterinari == null)
            {
                return HttpNotFound();
            }
            return View(veterinari);
        }

        // POST: Veterinari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veterinari veterinari = db.Veterinari.Find(id);
            db.Veterinari.Remove(veterinari);
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
