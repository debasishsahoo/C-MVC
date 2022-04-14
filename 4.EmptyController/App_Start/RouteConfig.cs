using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _4.EmptyController
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",//Default Routing
                url: "{controller}/{action}/{id}", //URL Pattern
                defaults: new {
                    controller = "Home", //Default Controller
                    action = "Index" //Deafult Action Method
                    id = UrlParameter.Optional //parameter
                }
            );
        }
    }
}
