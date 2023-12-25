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
    public class BusMasterController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: BusMaster
        public ActionResult Index()
        {
            return View(db.BusMasters.ToList());
        }

        // GET: BusMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusMaster busMaster = db.BusMasters.Find(id);
            if (busMaster == null)
            {
                return HttpNotFound();
            }
            return View(busMaster);
        }

        // GET: BusMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusMaster/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusId,BusNo,BustType,TotalSeat,SeatColumn,SeatRow,BookedSeat,AvailableSeats,BusName")] BusMaster busMaster)
        {
            if (ModelState.IsValid)
            {
                db.BusMasters.Add(busMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(busMaster);
        }

        // GET: BusMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusMaster busMaster = db.BusMasters.Find(id);
            if (busMaster == null)
            {
                return HttpNotFound();
            }
            return View(busMaster);
        }

        // POST: BusMaster/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusId,BusNo,BustType,TotalSeat,SeatColumn,SeatRow,BookedSeat,AvailableSeats,BusName")] BusMaster busMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(busMaster);
        }

        // GET: BusMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusMaster busMaster = db.BusMasters.Find(id);
            if (busMaster == null)
            {
                return HttpNotFound();
            }
            return View(busMaster);
        }

        // POST: BusMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusMaster busMaster = db.BusMasters.Find(id);
            db.BusMasters.Remove(busMaster);
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
