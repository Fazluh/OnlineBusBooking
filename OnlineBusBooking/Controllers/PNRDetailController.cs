using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineBusBooking;

namespace OnlineBusBooking.Controllers
{
    public class PNRDetailController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: PNRDetail
        public ActionResult Index()
        {
            return View(db.PNRDetails.ToList());
        }

        // GET: PNRDetail/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNRDetail pNRDetail = db.PNRDetails.Find(id);
            if (pNRDetail == null)
            {
                return HttpNotFound();
            }
            return View(pNRDetail);
        }

        // GET: PNRDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PNRDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PNRDetailsID,PNRNo,TotalAmount,TotalTickets,CreatedBy")] PNRDetail pNRDetail)
        {
            if (ModelState.IsValid)
            {
                db.PNRDetails.Add(pNRDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pNRDetail);
        }

        // GET: PNRDetail/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNRDetail pNRDetail = db.PNRDetails.Find(id);
            if (pNRDetail == null)
            {
                return HttpNotFound();
            }
            return View(pNRDetail);
        }

        // POST: PNRDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PNRDetailsID,PNRNo,TotalAmount,TotalTickets,CreatedBy")] PNRDetail pNRDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pNRDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pNRDetail);
        }

        // GET: PNRDetail/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNRDetail pNRDetail = db.PNRDetails.Find(id);
            if (pNRDetail == null)
            {
                return HttpNotFound();
            }
            return View(pNRDetail);
        }

        // POST: PNRDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PNRDetail pNRDetail = db.PNRDetails.Find(id);
            db.PNRDetails.Remove(pNRDetail);
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
