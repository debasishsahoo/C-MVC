using System.Web.Http;
using WebActivatorEx;
using WEBAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WEBAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", "WEBAPI");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\WEBAPI.xml",
                                       System.AppDomain.CurrentDomain.BaseDirectory));


                    })
                .EnableSwaggerUi(c =>
                    {
                      
                    });
        }
    }
}
