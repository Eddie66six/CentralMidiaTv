using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http;

[assembly: OwinStartup(typeof(CentralMidiaTv.servico.Startup))]

namespace CentralMidiaTv.servico
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthServerOptions;
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            ConfigureOAuth(app);

            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);

            #if DEBUG
            //TelemetryConfiguration.Active.DisableTelemetry = true;
            #endif
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthServerOptions = new OAuthAuthorizationServerOptions();
            //{
            //AllowInsecureHttp = true,
            //TokenEndpointPath = new PathString("/token"),
            //AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
            //Provider = new SimpleAuthorizationServerProvider()
            //};

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
