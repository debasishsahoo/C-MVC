using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MesageHandler.Models;

namespace MesageHandler
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new MsgHandler1());
            config.MessageHandlers.Add(new MsgHandler2());
            config.MessageHandlers.Add(new MsgHandler3());
            config.MessageHandlers.Add(new MsgHandler4());
            config.MessageHandlers.Add(new MsgHandler5("475411145555"));
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
