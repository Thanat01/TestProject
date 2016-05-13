using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using Library.Api.Authentication.AuthenResults;

namespace Library.Api.Authentication.AuthenFilters
{
    public abstract class AuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        public string Realm { get; set; }

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            HttpRequestMessage request = context.Request;
            AuthenticationHeaderValue authorization = request.Headers.Authorization;
      
            if (authorization == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Missing credentials", request);
                return;
            }

            if (String.IsNullOrEmpty(authorization.Parameter))
            {
                context.ErrorResult = new AuthenticationFailureResult("Missing credentials", request);
                return;
            }

            Tuple<string> Authen = ExtractParam(authorization.Parameter,false);
            
            if (Authen == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Invalid credentials", request);
                return;
            }

            string token = Authen.Item1;

            IPrincipal principal = await AuthenticateAsync(token, cancellationToken);

            if (principal == null)
            {
                HttpContext.Current.Response.Headers.Add("MC","30");
                context.ErrorResult = new AuthenticationFailureResult("Service API Authentication failed.", request);
            }
            else
            {
                context.Principal = principal;
            }
        }

        protected abstract Task<IPrincipal> AuthenticateAsync(string token, CancellationToken cancellationToken);


        private static Tuple<string> ExtractParam(string authorizationParameter, bool isBase64 = false)
        {
            string decodedCredentials;

            try
            {
                if (isBase64)
                {
                    byte[] credentialBytes;
                    credentialBytes = Convert.FromBase64String(authorizationParameter);
                    Encoding encoding = Encoding.ASCII;
                    encoding = (Encoding)encoding.Clone();
                    encoding.DecoderFallback = DecoderFallback.ExceptionFallback;

                    try
                    {
                        decodedCredentials = encoding.GetString(credentialBytes);
                    }
                    catch (DecoderFallbackException)
                    {
                        return null;
                    }
                }
                else decodedCredentials = authorizationParameter;

                if (String.IsNullOrEmpty(decodedCredentials))
                {
                    return null;
                }

                string[] tempParam = decodedCredentials.Split('|');
            }
            catch
            {
                return null;
            }

            return new Tuple<string>(decodedCredentials);
        }
         

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            Challenge(context);
            return Task.FromResult(0);
        }

        private void Challenge(HttpAuthenticationChallengeContext context)
        {
            string parameter;

            if (String.IsNullOrEmpty(Realm))
            {
                parameter = null;
            }
            else
            {
                // A correct implementation should verify that Realm does not contain a quote character unless properly
                // escaped (precededed by a backslash that is not itself escaped).
                parameter = "realm=\"" + Realm + "\"";
            }

           // context.ChallengeWith("Alpha", parameter);
        }

        public virtual bool AllowMultiple
        {
            get { return false; }
        }
    }

}