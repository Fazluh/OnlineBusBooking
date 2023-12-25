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
    public class RouteDetailController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: RouteDetail
        public ActionResult Index()
        {
            return View(db.RouteDetails.ToList());
        }

        // GET: RouteDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteDetail routeDetail = db.RouteDetails.Find(id);
            if (routeDetail == null)
            {
                return HttpNotFound();
            }
            return View(routeDetail);
        }

        // GET: RouteDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RouteDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RouteID,Origin,Destination,CreatedDate,BusID")] RouteDetail routeDetail)
        {
            if (ModelState.IsValid)
            {
                db.RouteDetails.Add(routeDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(routeDetail);
        }

        // GET: RouteDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteDetail routeDetail = db.RouteDetails.Find(id);
            if (routeDetail == null)
            {
                return HttpNotFound();
            }
            return View(routeDetail);
        }

        // POST: RouteDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RouteID,Origin,Destination,CreatedDate,BusID")] RouteDetail routeDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(routeDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(routeDetail);
        }

        // GET: RouteDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteDetail routeDetail = db.RouteDetails.Find(id);
            if (routeDetail == null)
            {
                return HttpNotFound();
            }
            return View(routeDetail);
        }

        // POST: RouteDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RouteDetail routeDetail = db.RouteDetails.Find(id);
            db.RouteDetails.Remove(routeDetail);
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
