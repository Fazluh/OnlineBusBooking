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
    public class CityDetailController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: CityDetail
        public ActionResult Index()
        {
            return View(db.CityDetails.ToList());
        }

        // GET: CityDetail/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityDetail cityDetail = db.CityDetails.Find(id);
            if (cityDetail == null)
            {
                return HttpNotFound();
            }
            return View(cityDetail);
        }

        // GET: CityDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityID,CityName")] CityDetail cityDetail)
        {
            if (ModelState.IsValid)
            {
                db.CityDetails.Add(cityDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityDetail);
        }

        // GET: CityDetail/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityDetail cityDetail = db.CityDetails.Find(id);
            if (cityDetail == null)
            {
                return HttpNotFound();
            }
            return View(cityDetail);
        }

        // POST: CityDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityID,CityName")] CityDetail cityDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityDetail);
        }

        // GET: CityDetail/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityDetail cityDetail = db.CityDetails.Find(id);
            if (cityDetail == null)
            {
                return HttpNotFound();
            }
            return View(cityDetail);
        }

        // POST: CityDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CityDetail cityDetail = db.CityDetails.Find(id);
            db.CityDetails.Remove(cityDetail);
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
