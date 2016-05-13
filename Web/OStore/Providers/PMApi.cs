using OStore.ModelApi;
using OStore.Models;
using OStore.Models.Customer;
using OStore.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Providers
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

        #region Product Category
        internal List<ProductCategoryViewModel> GetProductCategories()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                ProductCategoryResponseModel response = api.ApiRequest<ProductCategoryResponseModel>("Category/GetAllCategory", new ProductCategoryRequestModel());
                if (response.ResponseCode == "OK")
                    return response.Categories;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal void UpdateProductCategory(UpdateProductCategoryResquestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdateProductCategoryResponseModel response = api.ApiRequest<UpdateProductCategoryResponseModel>("Category/UpdateCategory", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Product
        internal List<ProductViewModel> GetProduct(GetProductRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetProductResponseModel response = api.ApiRequest<GetProductResponseModel>("Product/GetProducts", model);
                if (response.ResponseCode == "OK")
                    return response.Products;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdateProduct(UpdateProductRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdateProductResponseModel response = api.ApiRequest<UpdateProductResponseModel>("Product/UpdateProduct", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Promotion
        internal List<PromotionViewModel> GetPromotions(GetProductRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetPromotionsResponseModel response = api.ApiRequest<GetPromotionsResponseModel>("Promotion/GetPromotions", model);
                if (response.ResponseCode == "OK")
                    return response.Promotions;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdatePromotion(UpdatePromotionRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdatePromotionResponseModel response = api.ApiRequest<UpdatePromotionResponseModel>("Promotion/UpdatePromotion", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);

                SessionProvider.Instance.ClearPromotions();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Payments
        internal List<PaymentChannelModel> GetPaymentChannels(GetPaymentChannelsRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetPaymentChannelsResponseModel response = api.ApiRequest<GetPaymentChannelsResponseModel>("Payment/GetPaymentChannels", model);
                if (response.ResponseCode == "OK")
                    return response.Channels;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdatePaymentChannels(UpdatePaymentChannelsRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdatePaymentChannelsResponseModel response = api.ApiRequest<UpdatePaymentChannelsResponseModel>("Payment/UpdatePaymentChannels", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);

                SessionProvider.Instance.ClearPayments();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Customers
        internal List<CustomerModel> GetCustomers(GetCustomersRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetCustomersResponseModel response = api.ApiRequest<GetCustomersResponseModel>("Customer/GetCustomers", model);
                if (response.ResponseCode == "OK")
                    return response.Customers;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void UpdateCustomers(UpdateCustomersRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                UpdateCustomersResponseModel response = api.ApiRequest<UpdateCustomersResponseModel>("Customer/UpdateCustomers", model);
                if (response.ResponseCode != "OK")
                    throw new Exception(response.ResponseMessage);

                SessionProvider.Instance.ClearCustomers();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Location
        internal List<ProvinceModel> GetProvinces()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetProvinceResponseModel response = api.ApiRequest<GetProvinceResponseModel>("Location/GetProvinces", new GetProvinceRequestModel());
                if (response.ResponseCode == "OK")
                    return response.Provinces;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<DistrictModel> GetDistricts()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetDistrictResponseModel response = api.ApiRequest<GetDistrictResponseModel>("Location/GetDistricts", new GetDistrictRequestModel());
                if (response.ResponseCode == "OK")
                    return response.Districts;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<SubDistrictModel> GetSubDistricts()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetSubDistrictResponseModel response = api.ApiRequest<GetSubDistrictResponseModel>("Location/GetSubDistricts", new GetSubDistrictRequestModel());
                if (response.ResponseCode == "OK")
                    return response.SubDistricts;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<PostalCodeModel> GetPostalCodes()
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetPostalCodeResponseModel response = api.ApiRequest<GetPostalCodeResponseModel>("Location/GetPostalCodes", new GetPostalCodeRequestModel());
                if (response.ResponseCode == "OK")
                    return response.PostalCodes;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Delivery
        internal List<Models.Delivery.DeliveryChannelModel> GetDeliveryChannels(GetDeliveryChannelRequestModel model)
        {
            try
            {
                Library.Api.Request.ApiService api = new Library.Api.Request.ApiService(ConfigurationProvider.Instance.PMHostUrl, ConfigurationProvider.Instance.PMPublicKey, SessionProvider.Instance.CurrentShop.Id, UserId, UserName, Password, null);
                GetDeliveryChannelResponseModel response = api.ApiRequest<GetDeliveryChannelResponseModel>("Delivery/GetDeliveryChannels", model);
                if (response.ResponseCode == "OK")
                    return response.DeliveryChannels;
                else
                    throw new Exception(response.ResponseMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}