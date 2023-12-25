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
    public class BookingMasterController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: BookingMaster
        public ActionResult Index()
        {
            return View(db.BookingMasters.ToList());
        }

        // GET: BookingMaster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingMaster bookingMaster = db.BookingMasters.Find(id);
            if (bookingMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookingMaster);
        }

        // GET: BookingMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingMaster/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingId,RegId,BusId,Fname,Lname,Email,Contact,City,SeatNo,TravelDate,Origin,Destination,BoardingID,Fare,PNRNo,ScheduleID")] BookingMaster bookingMaster)
        {
            if (ModelState.IsValid)
            {
                db.BookingMasters.Add(bookingMaster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookingMaster);
        }

        // GET: BookingMaster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingMaster bookingMaster = db.BookingMasters.Find(id);
            if (bookingMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookingMaster);
        }

        // POST: BookingMaster/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingId,RegId,BusId,Fname,Lname,Email,Contact,City,SeatNo,TravelDate,Origin,Destination,BoardingID,Fare,PNRNo,ScheduleID")] BookingMaster bookingMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingMaster);
        }

        // GET: BookingMaster/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingMaster bookingMaster = db.BookingMasters.Find(id);
            if (bookingMaster == null)
            {
                return HttpNotFound();
            }
            return View(bookingMaster);
        }

        // POST: BookingMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookingMaster bookingMaster = db.BookingMasters.Find(id);
            db.BookingMasters.Remove(bookingMaster);
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
