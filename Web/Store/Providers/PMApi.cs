using PM.Api.Models;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Providers
{
    public class PMApi
    {
        private static PMApi _instance;

        private int UserId
        {
            get
            {
                return 1;
            }
        }

        private string UserName
        {
            get
            {
                return "thanat.t";
            }
        }
        private string Password
        {
            get
            {
                return "1234567";
            }
        }

        public static PMApi Instance
        {
            get { return _instance ?? (_instance = new PMApi()); }
        }


        internal List<MenuItemModel> GetMenues()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetMenuesResponseModel response = api.ApiRequest<GetMenuesResponseModel>("Menu/GetMenues", new GetMenuesRequestModel());

                return response.Menues;
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}