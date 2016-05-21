using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PocFlowerPower.Data.Contracts;
using POCFlowerPower.Common;

namespace POCFlowerPower.Filters
{
    public class AuthLogAttribute : AuthorizeAttribute
    {
        private UnitOfWorkManager _unitOfWorkManager;
        private IFlowerPowerUnitOfWork _uofContext;


        public AuthLogAttribute()
        {
             View = "AuthorizeFailed";
            _unitOfWorkManager = new UnitOfWorkManager();
            _uofContext = _unitOfWorkManager.GetUofContext();
        }

        public string View { get; set; }

        /// <summary>
        /// Check for Authorization
        /// </summary>
        /// <param name="filterContext"></param>
       

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var allowedroles = this.Roles;
            var username = httpContext.User.Identity.GetUserName().ToString();
            var userRole = _uofContext.UserRoles.GetUserRoleByUsername(username);
            bool authorize = false;
            var rolesList = allowedroles.Split(',');
            foreach (var role in rolesList)
            {
               if(role.ToString().ToLower().Equals(userRole.ToLower()))
                {
                    authorize = true; /* return true if Entity has current user(active) with specific role */
                }
                break;
            }
            return authorize;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    



}
}