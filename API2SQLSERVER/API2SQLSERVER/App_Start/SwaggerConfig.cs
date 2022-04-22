using System.Web.Http;
//using System.Linq;
using WebActivatorEx;
using API2SQLSERVER;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace API2SQLSERVER
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", "API2SQLSERVER");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\API2SQLSERVER.xml",System.AppDomain.CurrentDomain.BaseDirectory));

                        //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());


                    })
                .EnableSwaggerUi(c =>
                    {
                        
                    });
        }
    }
}
