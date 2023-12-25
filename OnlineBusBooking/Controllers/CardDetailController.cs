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
    public class CardDetailController : Controller
    {
        private OnlineBusBookingEntities db = new OnlineBusBookingEntities();

        // GET: CardDetail
        public ActionResult Index()
        {
            return View(db.CardDetails.ToList());
        }

        // GET: CardDetail/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDetail cardDetail = db.CardDetails.Find(id);
            if (cardDetail == null)
            {
                return HttpNotFound();
            }
            return View(cardDetail);
        }

        // GET: CardDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CardID,UserID,CardType,BankName,CVVNo,CardNo,TotalAmount,CreatedBy")] CardDetail cardDetail)
        {
            if (ModelState.IsValid)
            {
                db.CardDetails.Add(cardDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cardDetail);
        }

        // GET: CardDetail/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDetail cardDetail = db.CardDetails.Find(id);
            if (cardDetail == null)
            {
                return HttpNotFound();
            }
            return View(cardDetail);
        }

        // POST: CardDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CardID,UserID,CardType,BankName,CVVNo,CardNo,TotalAmount,CreatedBy")] CardDetail cardDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardDetail);
        }

        // GET: CardDetail/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDetail cardDetail = db.CardDetails.Find(id);
            if (cardDetail == null)
            {
                return HttpNotFound();
            }
            return View(cardDetail);
        }

        // POST: CardDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CardDetail cardDetail = db.CardDetails.Find(id);
            db.CardDetails.Remove(cardDetail);
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
