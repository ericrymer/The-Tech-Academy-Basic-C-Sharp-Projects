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

        // GET: Insuree/Details/5
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                CalcQuote(insuree.Id);
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //Calculate Insurance Quote
        public ActionResult CalcQuote(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.Find(Id);
                var dateOfBirth = insuree.DateOfBirth;
                var carYear = insuree.CarYear;
                var carModel = insuree.CarModel;
                var carMake = insuree.CarMake;
                var speedingTickets = insuree.SpeedingTickets;
                var dui = insuree.DUI;
                var coverageType = insuree.CoverageType;

                var monthlyInsuraneQuote = 50.0m;

                if (dateOfBirth.Year >= 2003)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 100.0m;
                }
                else if (dateOfBirth.Year <= 2011 && dateOfBirth.Year >= 1996)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 50.0m;
                }
                else if (dateOfBirth.Year < 1996)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 25.0m;
                }
                if (carYear < 2000)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 25.0m;
                }
                else if (carYear > 2015)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 25.0m;
                }
                if (carMake.ToLower() == "porsche")
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + 25.0m;
                    if (carModel.ToLower() == "911 carerra")
                    {
                        monthlyInsuraneQuote = monthlyInsuraneQuote + 25.0m;
                    }
                }
                monthlyInsuraneQuote = monthlyInsuraneQuote + (speedingTickets * 10);

                if (dui == true)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + (monthlyInsuraneQuote * 0.25m);
                }
                if (coverageType == true)
                {
                    monthlyInsuraneQuote = monthlyInsuraneQuote + (monthlyInsuraneQuote * 0.50m);
                }
                insuree.Quote = monthlyInsuraneQuote;
                db.SaveChanges();
            }
            return View("Index");
        }
    }
}