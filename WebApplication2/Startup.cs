using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(YourNamespace.Startup))]

namespace YourNamespace
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Web API yapılandırması
			HttpConfiguration config = new HttpConfiguration();

			// OAuth Authentication Middleware
			ConfigureOAuth(app);

			// Web API ayarları
			config.MapHttpAttributeRoutes();

			app.UseWebApi(config);
		}

		private void ConfigureOAuth(IAppBuilder app)
		{
			OAuthAuthorizationServerOptions oauthOptions = new OAuthAuthorizationServerOptions();


			// OAuth Authorization Server Middleware'i ekleme
			app.UseOAuthAuthorizationServer(oauthOptions);

			// OAuth Bearer Authentication Middleware'i ekleme
			app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
		}
	}
}