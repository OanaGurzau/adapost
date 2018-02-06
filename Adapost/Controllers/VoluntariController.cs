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
    public class VoluntariController : Controller
    {
        private AdapostContext db = new AdapostContext();

        // GET: Voluntari
        public ActionResult Index()
        {
            return View(db.Vountari.ToList());
        }

        // GET: Voluntari/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntari voluntari = db.Vountari.Find(id);
            if (voluntari == null)
            {
                return HttpNotFound();
            }
            return View(voluntari);
        }

        // GET: Voluntari/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voluntari/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVoluntar,Nume,Prenume,NrTel,Adresa,Ocupatie,Email")] Voluntari voluntari)
        {
            if (ModelState.IsValid)
            {
                db.Vountari.Add(voluntari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(voluntari);
        }

        // GET: Voluntari/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntari voluntari = db.Vountari.Find(id);
            if (voluntari == null)
            {
                return HttpNotFound();
            }
            return View(voluntari);
        }

        // POST: Voluntari/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVoluntar,Nume,Prenume,NrTel,Adresa,Ocupatie,Email")] Voluntari voluntari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(voluntari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(voluntari);
        }

        // GET: Voluntari/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voluntari voluntari = db.Vountari.Find(id);
            if (voluntari == null)
            {
                return HttpNotFound();
            }
            return View(voluntari);
        }

        // POST: Voluntari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Voluntari voluntari = db.Vountari.Find(id);
            db.Vountari.Remove(voluntari);
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
