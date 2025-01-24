using Microsoft.Identity.Client;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;

namespace WebApplication2.Providers
{
	public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
	{
		//OAuthorizationServerProvider sınıfının client erişimine izin verebilmek override ediyor.

		public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
		{
			{
				context.Validated();
			}
		}

			//OAuthorizationServerProvider sınıfının kaynak erişimine izin verebilmek override ediyor.

			public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
		{ {
				context.OwinContext.Response.Headers.Add("access-Control-Allow-Origin", new[] { "*" });

				if (context.UserName == "testuser" && context.Password == "123456789")
				{
					var identity = new ClaimsIdentity(context.Options.AuthenticationType);
					identity.AddClaim(new Claim("sub", context.UserName));
					identity.AddClaim(new Claim("role", "user"));

					context.Validated(identity);
				}
				else
				{ context.SetError("invalid_grant", "Username or password incorrect");
				}


			}
		}
	}
}
