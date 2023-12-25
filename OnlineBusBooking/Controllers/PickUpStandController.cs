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
    public class PickUpStandController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: PickUpStand
        public ActionResult Index()
        {
            return View(db.PickUpStands.ToList());
        }

        // GET: PickUpStand/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpStand pickUpStand = db.PickUpStands.Find(id);
            if (pickUpStand == null)
            {
                return HttpNotFound();
            }
            return View(pickUpStand);
        }

        // GET: PickUpStand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickUpStand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StandId,RouteId,PlaceName,PlaceTime,BusID")] PickUpStand pickUpStand)
        {
            if (ModelState.IsValid)
            {
                db.PickUpStands.Add(pickUpStand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickUpStand);
        }

        // GET: PickUpStand/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpStand pickUpStand = db.PickUpStands.Find(id);
            if (pickUpStand == null)
            {
                return HttpNotFound();
            }
            return View(pickUpStand);
        }

        // POST: PickUpStand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StandId,RouteId,PlaceName,PlaceTime,BusID")] PickUpStand pickUpStand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickUpStand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickUpStand);
        }

        // GET: PickUpStand/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpStand pickUpStand = db.PickUpStands.Find(id);
            if (pickUpStand == null)
            {
                return HttpNotFound();
            }
            return View(pickUpStand);
        }

        // POST: PickUpStand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PickUpStand pickUpStand = db.PickUpStands.Find(id);
            db.PickUpStands.Remove(pickUpStand);
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
