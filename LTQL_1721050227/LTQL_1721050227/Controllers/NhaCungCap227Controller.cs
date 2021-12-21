using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050227.Models;

namespace LTQL_1721050227.Controllers
{
    public class NhaCungCap227Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: NhaCungCap227
        public ActionResult Index()
        {
            return View(db.NhaCungCap227s.ToList());
        }

        // GET: NhaCungCap227/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap227 nhaCungCap227 = db.NhaCungCap227s.Find(id);
            if (nhaCungCap227 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap227);
        }

        // GET: NhaCungCap227/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap227/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungcap,TenNhaCungCap")] NhaCungCap227 nhaCungCap227)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap227s.Add(nhaCungCap227);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap227);
        }

        // GET: NhaCungCap227/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap227 nhaCungCap227 = db.NhaCungCap227s.Find(id);
            if (nhaCungCap227 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap227);
        }

        // POST: NhaCungCap227/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungcap,TenNhaCungCap")] NhaCungCap227 nhaCungCap227)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap227).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap227);
        }

        // GET: NhaCungCap227/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap227 nhaCungCap227 = db.NhaCungCap227s.Find(id);
            if (nhaCungCap227 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap227);
        }

        // POST: NhaCungCap227/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap227 nhaCungCap227 = db.NhaCungCap227s.Find(id);
            db.NhaCungCap227s.Remove(nhaCungCap227);
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
