using OStore.ModelApi;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Providers
{
    public class OMApi
    {
        private static OMApi _instance;

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

        public static OMApi Instance
        {
            get { return _instance ?? (_instance = new OMApi()); }
        }

        internal List<SaleChannelViewModel> GetSaleChannels(GetSaleChannelRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.OMHostUrl, ConfigurationProvider.Instance.OMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetSaleChannelResponseModel response = api.ApiRequest<GetSaleChannelResponseModel>("SaleChannel/GetSaleChennels", model);
                if (response.ResponseCode == "OK")
                    return response.SaleChannels;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}