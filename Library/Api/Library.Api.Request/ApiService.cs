using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Api.Request
{
    public class ApiService
    {
        private string authorization;
        private string hostUrl;
        public ApiService(string host, string publicKey, int shopId, int userId, string userName, string password, DateTime? timeOut)
        {
            hostUrl = host;
            Library.Helper.Token.Client.TokenService token = new Library.Helper.Token.Client.TokenService(publicKey);
            authorization = string.Format("{0} {1}", "OStore", token.GenerateToken(shopId, userId, userName, password, timeOut));
        }

        public T ApiRequest<T>(string method, object data)
        {
            try
            {
                var response = CallAPI(method, data);
                var result = (response != null) ? Newtonsoft.Json.JsonConvert.DeserializeObject<T>(response) : default(T);
               
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CallAPI(string method, object data)
        {
            if (data == null)
            {
                return SendJsonRequest(string.Empty, hostUrl + method);
            }
            else
            {
                return SendJsonRequest(Newtonsoft.Json.JsonConvert.SerializeObject(data), hostUrl + method);
            }

        }

        private string SendJsonRequest(string requestMessage, string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 10 * 60 * 1000;
                request.ContentType = "text/json"; // Can change xml or json
                request.Headers.Add("Authorization", authorization);
                HttpCookie cookie = HttpContext.Current.Request.Cookies["OStore.Store"];
                var lan = "EN";
                if (cookie != null && cookie.Values["Language"] != null)
                {
                    if (cookie.Values["Language"] == "th-TH")
                    {
                        lan = "TH";
                    }
                }
                request.Headers.Add("Language", lan);
                request.Method = "POST"; using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(requestMessage);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseMessage = string.Empty;
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    responseMessage = streamReader.ReadToEnd(); //This is response from API 
                }
                return responseMessage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
