using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50;

                // Insuree Age
                var today = DateTime.Today;
                int age = today.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth > today.AddYears(-age)) age--;

                if (age <= 18) quote += 100;
                else if (age <= 25) quote += 50;
                else quote += 25;

                // Insuree Car Year
                if (insuree.CarYear < 2000) quote += 25;
                else if (insuree.CarYear > 2015) quote += 25;

                // Insuree Car Make / Model (Specific to Porsche 911 Carrera)
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                        quote += 25;
                }

                // Insuree Speeding Tickets
                quote += insuree.SpeedingTickets * 10;

                // Insuree DUI (if checkbox is ticked)
                if (insuree.DUI)
                    quote += quote * 0.25m;

                // Insuree Coverage Type (Full if checkbox is ticked)
                if (insuree.CoverageType)
                    quote += quote * 0.50m;

                insuree.Quote = quote;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50;

                // Insuree Age
                var today = DateTime.Today;
                int age = today.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth > today.AddYears(-age)) age--;

                if (age <= 18) quote += 100;
                else if (age <= 25) quote += 50;
                else quote += 25;

                // Insuree Car Year
                if (insuree.CarYear < 2000) quote += 25;
                else if (insuree.CarYear > 2015) quote += 25;

                // Insuree Car Make / Model (Specific to Porsche 911 Carrera)
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                        quote += 25;
                }

                // Insuree Speeding Tickets
                quote += insuree.SpeedingTickets * 10;

                // Insuree DUI
                if (insuree.DUI)
                    quote += quote * 0.25m;

                // Insuree Coverage Type (Full if checkbox is ticked)
                if (insuree.CoverageType)
                    quote += quote * 0.50m;

                insuree.Quote = quote;

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // ADMIN PAGE
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
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