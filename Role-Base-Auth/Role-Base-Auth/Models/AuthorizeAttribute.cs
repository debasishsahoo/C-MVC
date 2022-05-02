using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace Role_Base_Auth.Models
{
    public class AuthorizeAttribute:System.Web.Http.AuthorizeAttribute
    {
        //401(Unauthorized)
        //authentications
        //403(Forbidden)
        //
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
            base.HandleUnauthorizedRequest(actionContext);
            }
            else
            {
           actionContext.Response =new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
        }
    }
}