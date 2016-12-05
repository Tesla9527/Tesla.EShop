using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security.OAuth;

namespace Tesla.EShop
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            //TODO: 认证客户端访问
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }

        //public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        //{
        //    context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
        //    var result = ValidateUser(context.UserName, context.Password);
        //    if (!result.Pass)
        //    {
        //        context.SetError("invalid_grant", "invalid username or password");
        //        return;
        //    }
        //    context.Validated(GetClaimsPrincipal(result.User));
        //}

        //internal static ClaimsIdentity GetClaimsPrincipal(dynamic user)
        //{
        //    var claims = new List<Claim>();
        //    //claims.Add(new Claim(ClaimTypes.Name, user.Name));
        //    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserId));
        //    claims.Add(new Claim(YConst.LanguageCultrue, user.LanguageCulture));
        //    var identity = new ClaimsIdentity(claims, "ApplicationCookie");
        //    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
        //    HttpContext.Current.User = principal;
        //    return identity;
        //}
    }  
}