using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Common;

namespace POCFlowerPower.Controllers
{
    public class TestController : ApiController
    {
        // GET: Test
        private UnitOfWorkManager _unitOfWorkManager;
        private readonly IFlowerPowerUnitOfWork _uofContext;

        public TestController()
        {
            _unitOfWorkManager = new UnitOfWorkManager();
            _uofContext = _unitOfWorkManager.GetUofContext();
        }

      /*  public ActionResult Index()
        {
           // return View();

        }*/

        public string Get()
        { ///Session.
           
            var flowersfamily = _uofContext.ProductFamilies.GetAll();
            var x = flowersfamily.Select(a => a.FamilyName).FirstOrDefault();
            return x;
        }
    
    }
}