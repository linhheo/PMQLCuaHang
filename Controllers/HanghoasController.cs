﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BOHOPUB2HAND.Models;

namespace BOHOPUB2HAND.Controllers
{
    public class HanghoasController : Controller
    {
        private QLCuaHangdbContext db = new QLCuaHangdbContext();

        // GET: Hanghoas
        public ActionResult Index()
        {
            return View(db.Hanghoas.ToList());
        }

        // GET: Hanghoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanghoa hanghoa = db.Hanghoas.Find(id);
            if (hanghoa == null)
            {
                return HttpNotFound();
            }
            return View(hanghoa);
        }

        // GET: Hanghoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hanghoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HangHoaID,TenHangHoa,SoLuongTonKho,DonGia")] Hanghoa hanghoa)
        {
            if (ModelState.IsValid)
            {
                db.Hanghoas.Add(hanghoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hanghoa);
        }

        // GET: Hanghoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanghoa hanghoa = db.Hanghoas.Find(id);
            if (hanghoa == null)
            {
                return HttpNotFound();
            }
            return View(hanghoa);
        }

        // POST: Hanghoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HangHoaID,TenHangHoa,SoLuongTonKho,DonGia")] Hanghoa hanghoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hanghoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hanghoa);
        }

        // GET: Hanghoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hanghoa hanghoa = db.Hanghoas.Find(id);
            if (hanghoa == null)
            {
                return HttpNotFound();
            }
            return View(hanghoa);
        }

        // POST: Hanghoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hanghoa hanghoa = db.Hanghoas.Find(id);
            db.Hanghoas.Remove(hanghoa);
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
