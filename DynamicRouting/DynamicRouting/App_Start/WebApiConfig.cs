using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DynamicRouting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //To Handel The Product Controller
            //config.Routes.MapHttpRoute(
            //    name: "ProductApi",
            //    routeTemplate: "api/{controller}/public/{category}/{id}",
            //     defaults: new { 
            //         category="all",
            //         id = RouteParameter.Optional }
            //    );
            //api/product/public/books/145  -->it is Showing Single Book 
            //api/product/public/books      ---it is showing all Books
            //api/product/public/     -->it is showing All products



            //To Handel The Admin Controller
            //config.Routes.MapHttpRoute(
            //    name: "UserApi",
            //    routeTemplate: "api/user/{id}",
            //     defaults: new
            //     {
            //         Controller = "user",
            //         id = RouteParameter.Optional
            //     }
            //    );
            //api/user/145 ->it is showing single user
            //api/user/ ->it is showing All users


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }//,
                //constraints:new { id=@"\d+"}
            ) ;
        }
    }
}
