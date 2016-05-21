using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlorariaPOCData;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Common;
using POCFlowerPower.Filters;
using POCFlowerPower.Model;
using POCFlowerPower.Models;
using POCFlowerPower.Services;

namespace POCFlowerPower.Controllers
{
    public class ProductsController : Controller
    {
        private FlowerPowerDbContext db = new FlowerPowerDbContext();
        private UnitOfWorkManager _unitOfWorkManager;
        private readonly IFlowerPowerUnitOfWork _uofContext;

        
        public ProductsController()
        {

            _unitOfWorkManager = new UnitOfWorkManager();
            _uofContext = _unitOfWorkManager.GetUofContext();
        }
        // GET: Products
        [AuthLog(Roles = "Admin, Abc")]
        public ActionResult Index()
        { /*Session.a*/
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [AuthLog(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductName,Price,DiscountVal,ProductDescription,ProductImage")] Product product, HttpPostedFileBase imageData)
        {
            if (ModelState.IsValid)
            {
                if (imageData == null)
                {
                    imageData = Request.Files["ImageData"];
                }
            var prodImgService = new ProductImageService();
                prodImgService.UploadImageInDataBase(imageData, product);
              //  db.Products.Add(product);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }


        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductName,Price,DiscountVal,ProductDescription,ProductImage")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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

        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public byte[] GetImageFromDataBase(int id)
        {
            var product = _uofContext.Products.GetById(id);
            byte[] cover = product.ProductImage;
            return cover;
        }

 /*       [HttpPost, ActionName("AddToBascketList")]
        [ValidateAntiForgeryToken]*/
        public ActionResult AddToBascketList(int productId, int numberOfProd)
        {
            var sessionProduct = new SessionProduct()
            {
                ProductId =  productId,
                NrOfProducts =  numberOfProd
            };
            List<SessionProduct> sessProd = new List<SessionProduct>();
            var fromSession =  (List<SessionProduct>) Session["BascketListProd"];
            if (fromSession != null)
                sessProd = fromSession;
            sessProd.Add(sessionProduct);
            Session.Clear();
            Session.Add("BascketListProd", sessProd);

            
            return RedirectToAction("Index");
        }

       public ActionResult BascketList()
        {
            List<SessionProduct> sessionProduct = new List<SessionProduct>();
           var fromSession = Session["BascketListProd"] as List<SessionProduct>;
            if (fromSession != null)
                sessionProduct = fromSession;
            List<ProductWithNumber> model = new List<ProductWithNumber>();
           foreach (var sessionObj in sessionProduct)
           {
               var product = _uofContext.Products.GetById(sessionObj.ProductId);
               var prodWithNr = new ProductWithNumber()
               {

                   NrOfProducts = sessionObj.NrOfProducts,
                   ProductFamily = product.ProductFamily,
                   ProductName =  product.ProductName,
                   ProductDescription = product.ProductDescription,
                   Price=product.Price,
                   DiscountVal = product.DiscountVal,
                   ProductImage=product.ProductImage,
                   Id = product.Id
                   


               };
                model.Add(prodWithNr);
           }
           return View (model.ToList());
        }

       
        public ActionResult RemoveProduct(int id)
        {
            var fromSession = Session["BascketListProd"] as List<SessionProduct>;
            foreach (var x in fromSession.ToList())
            {
                if (x.ProductId == id)
                    if (fromSession != null) fromSession.Remove(x);
            }
            Session.Clear();
            Session.Add("BascketListProd", fromSession);
            return RedirectToAction("index");
        }
           

        public ActionResult Order()
        {
            throw new NotImplementedException();
        }
    }
}
