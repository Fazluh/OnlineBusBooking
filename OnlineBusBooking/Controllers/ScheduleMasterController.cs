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
    public class ScheduleMasterController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: ScheduleMaster
        public ActionResult Index()
        {
            return View(db.ScheduleMasters.ToList());
        }

        // GET: ScheduleMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleMaster scheduleMaster = db.ScheduleMasters.Find(id);
            if (scheduleMaster == null)
            {
                return HttpNotFound();
            }
            return View(scheduleMaster);
        }

        // GET: ScheduleMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduleMaster/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ScheduleId,BusId,Date,Fare,EstimatedTime,ArivalTime,DepartureTime,RouteID,BookedSeats,AvailableSeats")] ScheduleMaster scheduleMaster)
        {
            if (ModelState.IsValid)
            {
                db.ScheduleMasters.Add(scheduleMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scheduleMaster);
        }

        // GET: ScheduleMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleMaster scheduleMaster = db.ScheduleMasters.Find(id);
            if (scheduleMaster == null)
            {
                return HttpNotFound();
            }
            return View(scheduleMaster);
        }

        // POST: ScheduleMaster/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ScheduleId,BusId,Date,Fare,EstimatedTime,ArivalTime,DepartureTime,RouteID,BookedSeats,AvailableSeats")] ScheduleMaster scheduleMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduleMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scheduleMaster);
        }

        // GET: ScheduleMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleMaster scheduleMaster = db.ScheduleMasters.Find(id);
            if (scheduleMaster == null)
            {
                return HttpNotFound();
            }
            return View(scheduleMaster);
        }

        // POST: ScheduleMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScheduleMaster scheduleMaster = db.ScheduleMasters.Find(id);
            db.ScheduleMasters.Remove(scheduleMaster);
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
