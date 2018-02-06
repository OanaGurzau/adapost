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
    public class AngajatiController : Controller
    {
        private AdapostContext db = new AdapostContext();

        // GET: Angajati
        public ActionResult Index()
        {
            return View(db.Angajati.ToList());
        }

        // GET: Angajati/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Angajati angajati = db.Angajati.Find(id);
            if (angajati == null)
            {
                return HttpNotFound();
            }
            return View(angajati);
        }

        // GET: Angajati/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Angajati/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAngajat,Nume,Prenume,NrTel,Adresa,Email")] Angajati angajati)
        {
            if (ModelState.IsValid)
            {
                db.Angajati.Add(angajati);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(angajati);
        }

        // GET: Angajati/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Angajati angajati = db.Angajati.Find(id);
            if (angajati == null)
            {
                return HttpNotFound();
            }
            return View(angajati);
        }

        // POST: Angajati/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAngajat,Nume,Prenume,NrTel,Adresa,Email")] Angajati angajati)
        {
            if (ModelState.IsValid)
            {
                db.Entry(angajati).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(angajati);
        }

        // GET: Angajati/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Angajati angajati = db.Angajati.Find(id);
            if (angajati == null)
            {
                return HttpNotFound();
            }
            return View(angajati);
        }

        // POST: Angajati/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Angajati angajati = db.Angajati.Find(id);
            db.Angajati.Remove(angajati);
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
