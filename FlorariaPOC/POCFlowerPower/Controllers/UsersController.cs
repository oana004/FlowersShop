using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Common;
using POCFlowerPower.Model;

namespace POCFlowerPower.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        /*public ActionResult Index()
        {
            return View();
        }*/
        private UnitOfWorkManager _unitOfWorkManager;
        private readonly IFlowerPowerUnitOfWork _uofContext;

        public UsersController()
        {
            _unitOfWorkManager = new UnitOfWorkManager();
            _uofContext = _unitOfWorkManager.GetUofContext();

        }

        public ActionResult Index()
        {
           var model =  _uofContext.Products.GetById(1);
            return View("Users", model);
        }
        /*     public IEnumerable<User> Get()
            {/*
                var users  = _unitOfWorkManager.
                    .OrderBy(s => s.DateDetailsId);

                return #1#
                return;
            }

            // GET /api/Events/5
            public Event Get(int id)
            {
                var unitOfwork = _businessServiceProvider.Resolve<IEventsItUnitOfWork>();
                var selevent = unitOfwork.Events.GetById(id);
                if (selevent != null) return selevent;
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            // Create a new Event
            // POST /api/Event
            public HttpResponseMessage Post(Event selectedEvent)
            {
                var unitOfwork = _businessServiceProvider.Resolve<IEventsItUnitOfWork>();
                unitOfwork.Events.Add(selectedEvent);
                unitOfwork.Commit();

                var response = Request.CreateResponse(HttpStatusCode.Created, selectedEvent);

                // Compose location header that tells how to get this Event
                // e.g. ~/api/Event/5
                response.Headers.Location =
                    new Uri(Url.Link(WebApiConfig.ControllerAndId, new { id = selectedEvent.Id }));

                return response;
            }

            // Update an existing Event
            // PUT /api/Events/
            public HttpResponseMessage Put(Event selEvent)
            {
                var unitOfwork = _businessServiceProvider.Resolve<IEventsItUnitOfWork>();
                unitOfwork.Events.Update(selEvent);
                unitOfwork.Commit();
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }

            // DELETE /api/Events/5
            public HttpResponseMessage Delete(int id)
            {
                var unitOfwork = _businessServiceProvider.Resolve<IEventsItUnitOfWork>();
                unitOfwork.Events.Delete(id);
                unitOfwork.Commit();
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }*/

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }
    }
}