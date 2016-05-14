using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using POCFlowerPower.Common;

namespace POCFlowerPower.Controllers
{
    public class TestController : ApiController
    {
        // GET: Test
        private UnitOfWorkManager _unitOfWorkManager;

        public TestController()
        {
            _unitOfWorkManager = new UnitOfWorkManager();
        }

      /*  public ActionResult Index()
        {
           // return View();

        }*/

        public string Get()
        {
            var uofctx = _unitOfWorkManager.GetUofContext();
            var flowersfamily = uofctx.ProductFamilies.GetAll();
            var x = flowersfamily.Select(a => a.FamilyName).FirstOrDefault();
            return x;
        }
    
    }
}