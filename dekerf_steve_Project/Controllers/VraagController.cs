using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dekerf_steve_Project;

namespace dekerf_steve_Project.Controllers
{
    public class VraagController : Controller
    {
        private project db = new project();

        // GET: Vraag
        public ActionResult Index()
        {

           



            return View(db.Vraags.ToList());
        }

        // GET: Vraag/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vraag vraag = db.Vraags.Find(id);
            if (vraag == null)
            {
                return HttpNotFound();
            }
            return View(vraag);
        }

        // GET: Vraag/Create
        public ActionResult Create()
        { 
            return View();
        }

        // POST: Vraag/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,naam,voornaam,adres,gemeente,type,content,date")] Vraag vraag)
        {
            if (ModelState.IsValid)
            {
                db.Vraags.Add(vraag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vraag);
        }

        // GET: Vraag/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vraag vraag = db.Vraags.Find(id);
            if (vraag == null)
            {
                return HttpNotFound();
            }
            return View(vraag);
        }

        // POST: Vraag/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,naam,voornaam,adres,gemeente,type,content,date")] Vraag vraag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vraag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vraag);
        }

        // GET: Vraag/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vraag vraag = db.Vraags.Find(id);
            if (vraag == null)
            {
                return HttpNotFound();
            }
            return View(vraag);
        }

        // POST: Vraag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vraag vraag = db.Vraags.Find(id);
            db.Vraags.Remove(vraag);
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
