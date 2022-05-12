using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using TokenBasedAuth.Models;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http;


[assembly: OwinStartup(typeof(TokenBasedAuth.App_Start.Startup))]

namespace TokenBasedAuth.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new MyAuthorizationServerProvider()

            };

            app.UseOAuthAuthorizationServer(options);

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
        }
    }
}
