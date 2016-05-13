using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Library.Api.Authentication.AuthenFilters;

namespace Library.Api.Authentication.AuthenFileters
{
    public class AlphaAuthenticationAttribute : AuthenticationAttribute
    {
        public AlphaAuthenticationAttribute()
        {

        }

        protected override async Task<IPrincipal> AuthenticateAsync(string token, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ALPHA.Helper.Token.TokenService service = new ALPHA.Helper.Token.TokenService("OShop");
            List<string> results = service.VerifyToken(token);

            if (results.Count > 0)
            {
                string lang = "EN"; IEnumerable<string> languages = System.Web.HttpContext.Current.Request.Headers.GetValues("Language");
                if (languages != null)
                    lang = languages.FirstOrDefault().ToUpper();

                try
                {
                    Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
                }
                catch (System.Globalization.CultureNotFoundException) { }

                var claims = new List<Claim>();
                //claims.Add(new Claim(AlphaClaimTypes.EntityTypeId, model.EntityTypeId.ToString()));
                //claims.Add(new Claim(AlphaClaimTypes.UserRoleId, model.UserRoleId.ToString()));
                //claims.Add(new Claim(AlphaClaimTypes.EntityId, model.EntityTypeId == 1 ? model.EntityId : "99999999"));
                //claims.Add(new Claim(AlphaClaimTypes.Username, model.UserName));
                //claims.Add(new Claim(AlphaClaimTypes.CustomerId, model.EntityId));

                ClaimsIdentity identity = new ClaimsIdentity(claims, "Alpha");
                var principal = new ClaimsPrincipal(identity);

                return principal;
            }
            else
            {
                System.Web.HttpContext.Current.Response.Headers["Status"] = "Unauthorized";
                return null;
            }
        }
    }
}