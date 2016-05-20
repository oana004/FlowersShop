using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Common;
using POCFlowerPower.Model;

namespace POCFlowerPower.Services
{
    public class ProductImageService
    {

        private UnitOfWorkManager _unitOfWorkManager;
        private readonly IFlowerPowerUnitOfWork _uofContext;

        public ProductImageService()
        {
            _unitOfWorkManager = new UnitOfWorkManager();
            _uofContext = _unitOfWorkManager.GetUofContext();

        }

      
        //private readonly DBContext db = new DBContext();
        public void UploadImageInDataBase(HttpPostedFileBase file, Product product)
        {
            
                
                
             product.ProductImage  =  ConvertToBytes(file);
            _uofContext.Products.Add(product);
          _uofContext.Commit();
          
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}