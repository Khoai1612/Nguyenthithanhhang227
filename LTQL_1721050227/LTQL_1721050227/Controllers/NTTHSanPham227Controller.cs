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
    public class NTTHSanPham227Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: NTTHSanPham227
        public ActionResult Index()
        {
            var nTTHSanPham227 = db.NTTHSanPham227.Include(n => n.NhaCungCap227);
            return View(nTTHSanPham227.ToList());
        }

        // GET: NTTHSanPham227/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTHSanPham227 nTTHSanPham227 = db.NTTHSanPham227.Find(id);
            if (nTTHSanPham227 == null)
            {
                return HttpNotFound();
            }
            return View(nTTHSanPham227);
        }

        // GET: NTTHSanPham227/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap227, "MaNhaCungcap", "TenNhaCungCap");
            return View();
        }

        // POST: NTTHSanPham227/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTTHSanPham227 nTTHSanPham227)
        {
            if (ModelState.IsValid)
            {
                db.NTTHSanPham227.Add(nTTHSanPham227);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap227, "MaNhaCungcap", "TenNhaCungCap", nTTHSanPham227.MaNhaCungCap);
            return View(nTTHSanPham227);
        }

        // GET: NTTHSanPham227/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTHSanPham227 nTTHSanPham227 = db.NTTHSanPham227.Find(id);
            if (nTTHSanPham227 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap227, "MaNhaCungcap", "TenNhaCungCap", nTTHSanPham227.MaNhaCungCap);
            return View(nTTHSanPham227);
        }

        // POST: NTTHSanPham227/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTTHSanPham227 nTTHSanPham227)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nTTHSanPham227).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap227, "MaNhaCungcap", "TenNhaCungCap", nTTHSanPham227.MaNhaCungCap);
            return View(nTTHSanPham227);
        }

        // GET: NTTHSanPham227/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTTHSanPham227 nTTHSanPham227 = db.NTTHSanPham227.Find(id);
            if (nTTHSanPham227 == null)
            {
                return HttpNotFound();
            }
            return View(nTTHSanPham227);
        }

        // POST: NTTHSanPham227/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NTTHSanPham227 nTTHSanPham227 = db.NTTHSanPham227.Find(id);
            db.NTTHSanPham227.Remove(nTTHSanPham227);
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
