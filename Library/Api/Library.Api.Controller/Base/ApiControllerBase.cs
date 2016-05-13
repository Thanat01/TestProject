using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web;

namespace Library.Api.Controller.Base
{
    public class ApiControllerBase : ApiController
    {
        protected int CurrentShopId
        {
            get
            {
                return Convert.ToInt32(GetTokenValue(0));
            }
        }

        protected int CurrentUserId
        {
            get
            {
                return Convert.ToInt32(GetTokenValue(1));
            }
        }

        private string GetTokenValue(int keyIndex)
        {
            try
            {
                string value = string.Empty;

                IEnumerable<string> authen = HttpContext.Current.Request.Headers.GetValues("Authorization");
                if (authen != null)
                {
                    Library.Helper.Token.TokenService token = new Helper.Token.TokenService("OSTORE");
                    string[] values = token.VerifyToken(authen.FirstOrDefault().Replace("OStore ", ""));
                    if (values.Length > keyIndex)
                        value = values[keyIndex];
                    else
                        throw new Exception("Invalid token key.");

                }

                return value;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
