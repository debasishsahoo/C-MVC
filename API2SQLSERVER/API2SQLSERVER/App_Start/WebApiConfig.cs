using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API2SQLSERVER
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            EnableCorsAttribute cors = new EnableCorsAttribute("https://localhost:44354/", "http://127.0.0.1:4200", "http://127.0.0.1:5200");
            config.EnableCors(cors);
        }
    }

    //public class CustoJsonFormatter : JsonMediaTypeFormatter
    //{
    //    public CustoJsonFormatter()
    //    {
    //        this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
    //    }
    //}
}
