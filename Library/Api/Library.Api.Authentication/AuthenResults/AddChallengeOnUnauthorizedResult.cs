using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Library.Api.Authentication.AuthenResults
{
    public class AddChallengeOnUnauthorizedResult : IHttpActionResult
    {
        public AddChallengeOnUnauthorizedResult(AuthenticationHeaderValue challenge, IHttpActionResult innerResult)
        {
            Challenge = challenge;
            InnerResult = innerResult;
        }

        public AuthenticationHeaderValue Challenge { get; private set; }

        public IHttpActionResult InnerResult { get; private set; }

        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage response = await InnerResult.ExecuteAsync(cancellationToken);

            if (HttpContext.Current.Response.Headers["Status"] == null)
            {
                HttpContext.Current.Response.Headers.Add("Status", "OK");
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                if (HttpContext.Current.Response.Headers["Status"] == "Invalid version")
                {
                    response.Content = new StringContent("{\"TimeStamp\":\"" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffzzz") + "\",\"ResponseCode\":\"InvalidVersion\",\"ResponseMessage\":\"Invalid version\"}", Encoding.UTF8, "application/json");
                }
                else
                {
                    HttpContext.Current.Response.Headers["Status"] = "Unauthorized";
                    response.Content = new StringContent("Service Api Authentication fail.", Encoding.UTF8, "text/plain");
                }
            }

            if (response.Content != null && (response.Content is  System.Net.Http.ObjectContent && ((System.Net.Http.ObjectContent)(response.Content)).Value == null))
            {
                ((System.Net.Http.ObjectContent)(response.Content)).Value = Newtonsoft.Json.Linq.JObject.Parse("{success : false}");
            }

            return response;
        }
    }

}