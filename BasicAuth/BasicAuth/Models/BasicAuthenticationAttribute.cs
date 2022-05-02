using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BasicAuth.Models
{
    public class BasicAuthenticationAttribute:AuthorizationFilterAttribute
    {
        private const string Realm = "My Realm";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);

                if (actionContext.Response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    actionContext.Response.Headers.Add("WWW-Authenticate", String.Format("Basic realm=\"{0}\"", Realm));

                }
                    
            }
            else
            {
                //Get Auth token from request Header
                string AuthToken= actionContext.Request.Headers.Authorization.Parameter;
                //Decode The String
                string DecodeAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(AuthToken));
                //Convert the String into an String array
                string[] AuthTokenArray = DecodeAuthToken.Split(':');
                //First Element of the array is User Name
                string username = AuthTokenArray[0];
                //Second Element of the array is Password
                string password = AuthTokenArray[1];
                //Call the Login method to check the username and password
                    if (UserValidator.Login(username, password)) 
                    {
                        var identity=new GenericIdentity(username);
                        IPrincipal principal=new GenericPrincipal(identity,null);
                        Thread.CurrentPrincipal = principal;
                        if (HttpContext.Current!=null)
                        {
                            HttpContext.Current.User=principal;
                        }
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    }
            }
        }
    }
}