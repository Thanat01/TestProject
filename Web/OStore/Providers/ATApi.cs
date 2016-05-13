using OStore.ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Providers
{
    public class ATApi
    {
        private static ATApi _instance;

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

        public static ATApi Instance
        {
            get { return _instance ?? (_instance = new ATApi()); }
        }

        internal UserInfoResponseModel InternalSignIn(string userName, string password)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.ATHostUrl, ConfigurationProvider.Instance.ATPublicKey, SessionProvider.Instance.CurrentShop.Id, 0, UserName, Password, null);
                UserInfoResponseModel response = api.ApiRequest<UserInfoResponseModel>("Account/InternalSignIn", new InternalSingInRequestModel() { UserName = userName, Password = password });
                if (response.ResponseCode == "OK")
                    response.Status = Microsoft.AspNet.Identity.Owin.SignInStatus.Success;
                else
                    response.Status = Microsoft.AspNet.Identity.Owin.SignInStatus.Failure;

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal UserInfoResponseModel ExternalSignIn(string externalSystem, string externalUserId)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.ATHostUrl, ConfigurationProvider.Instance.ATPublicKey, SessionProvider.Instance.CurrentShop.Id, 0, UserName, Password, null);
                UserInfoResponseModel response = api.ApiRequest<UserInfoResponseModel>("Account/ExternalSignIn", new ExternalSingInRequestModel() { ExternalSystem = externalSystem, ExternalUserId = externalUserId });
                if (response.ResponseCode == "OK")
                    response.Status = Microsoft.AspNet.Identity.Owin.SignInStatus.Success;
                else
                    response.Status = Microsoft.AspNet.Identity.Owin.SignInStatus.Failure;

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Shop
        internal GetShopInfoResponseModel GetShopInfo()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.ATHostUrl, ConfigurationProvider.Instance.ATPublicKey, 0, 0, UserName, Password, null);
                GetShopInfoResponseModel response = api.ApiRequest<GetShopInfoResponseModel>("Shop/GetShopInfo", new GetShopInfoRequestModel() { DNS = HttpContext.Current.Request.Url.OriginalString });
                if (response.ResponseCode == "OK")
                    return response;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdateShopInfo(UpdateShopInfoRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.ATHostUrl, ConfigurationProvider.Instance.ATPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdateShopInfoResponseModel response = api.ApiRequest<UpdateShopInfoResponseModel>("Shop/UpdateShopInfo", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);

                SessionProvider.Instance.ClearShopInfo();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}