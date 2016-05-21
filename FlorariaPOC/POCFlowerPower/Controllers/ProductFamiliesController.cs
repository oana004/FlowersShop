using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlorariaPOCData;
using POCFlowerPower.Model;

namespace POCFlowerPower.Controllers
{
    public class ProductFamiliesController : Controller
    {
        private FlowerPowerDbContext db = new FlowerPowerDbContext();

        // GET: ProductFamilies
        public ActionResult Index()
        {
            return View(db.ProductFamilies.ToList());
        }

        // GET: ProductFamilies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductFamily productFamily = db.ProductFamilies.Find(id);
            if (productFamily == null)
            {
                return HttpNotFound();
            }
            return View(productFamily);
        }

        // GET: ProductFamilies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductFamilies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FamilyName,Specifications")] ProductFamily productFamily)
        {
            if (ModelState.IsValid)
            {
                db.ProductFamilies.Add(productFamily);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productFamily);
        }

        // GET: ProductFamilies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductFamily productFamily = db.ProductFamilies.Find(id);
            if (productFamily == null)
            {
                return HttpNotFound();
            }
            return View(productFamily);
        }

        // POST: ProductFamilies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FamilyName,Specifications")] ProductFamily productFamily)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productFamily).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productFamily);
        }

        // GET: ProductFamilies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductFamily productFamily = db.ProductFamilies.Find(id);
            if (productFamily == null)
            {
                return HttpNotFound();
            }
            return View(productFamily);
        }

        // POST: ProductFamilies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductFamily productFamily = db.ProductFamilies.Find(id);
            db.ProductFamilies.Remove(productFamily);
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
