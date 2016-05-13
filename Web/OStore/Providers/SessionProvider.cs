using OStore.Models;
using OStore.Models.Customer;
using OStore.Models.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Providers
{
    public class SessionProvider : Library.Api.Handler.SessionHandler
    {
        private static SessionProvider _instance;
        public static SessionProvider Instance
        {
            get { return _instance ?? (_instance = new SessionProvider()); }
        }

        internal List<MenuItemModel> Menues
        {
            get
            {
                if (!IsExist("Menues"))
                {
                    Set<List<MenuItemModel>>("Menues", PMApi.Instance.GetMenues());
                }

                return Get<List<MenuItemModel>>("Menues");
            }
        }

        #region Shop
        public ShopModel CurrentShop
        {
            get
            {
                if (!IsExist("CurrentShop"))
                {
                    Set<ShopModel>("CurrentShop", ATApi.Instance.GetShopInfo().Shop);
                }

                return Get<ShopModel>("CurrentShop");
            }
        }
        internal void ClearShopInfo()
        {
            Remove("CurrentShop");
        }
        #endregion

        #region  Product Category
        internal List<ProductCategoryViewModel> ProductCategories
        {
            get
            {
                if (!IsExist("ProductCategories"))
                {
                    Set<List<ProductCategoryViewModel>>("ProductCategories", PMApi.Instance.GetProductCategories());
                }

                return Get<List<ProductCategoryViewModel>>("ProductCategories");
            }
        }

        internal void ClearProductCategories()
        {
            Remove("ProductCategories");
        }
        #endregion

        #region Product
        internal List<ProductViewModel> GetProduct(int categoryId)
        {
            string sessionName = string.Format("GetProduct_{0}", categoryId);
            if (!IsExist(sessionName))
            {
                Set<List<ProductViewModel>>(sessionName, PMApi.Instance.GetProduct(new ModelApi.GetProductRequestModel() { CategoryId = categoryId }));
            }

            return Get<List<ProductViewModel>>(sessionName);
        }

        #endregion

        #region Promotion
        internal List<PromotionViewModel> Promotions
        {
            get
            {
                string sessionName = "Promotions";
                if (!IsExist(sessionName))
                {
                    Set<List<PromotionViewModel>>(sessionName, PMApi.Instance.GetPromotions(new ModelApi.GetProductRequestModel() { }));
                }

                return Get<List<PromotionViewModel>>(sessionName);
            }
        }
        internal void ClearPromotions()
        {
            Remove("Promotions");
        }
        #endregion

        #region Payment channel
        public List<PaymentChannelModel> PaymentChannels
        {
            get
            {
                string sessionName = "PaymentChannels";
                if (!IsExist(sessionName))
                {
                    Set<List<PaymentChannelModel>>(sessionName, PMApi.Instance.GetPaymentChannels(new ModelApi.GetPaymentChannelsRequestModel()));
                }

                return Get<List<PaymentChannelModel>>(sessionName);
            }
        }
        internal void ClearPayments()
        {
            Remove("PaymentChannels");
        }
        #endregion

        #region Customers
        public List<CustomerModel> Customers
        {
            get
            {
                string sessionName = "Customers";
                if (!IsExist(sessionName))
                {
                    Set<List<CustomerModel>>(sessionName, PMApi.Instance.GetCustomers(new ModelApi.GetCustomersRequestModel()));
                }

                return Get<List<CustomerModel>>(sessionName);
            }
        }
        internal void ClearCustomers()
        {
            Remove("Customers");
        }
        #endregion

        #region Sale Channel
        public List<SaleChannelViewModel> SaleChannels
        {
            get
            {
                string sessionName = "SaleChannels";
                if (!IsExist(sessionName))
                {
                    Set<List<SaleChannelViewModel>>(sessionName, OMApi.Instance.GetSaleChannels(new ModelApi.GetSaleChannelRequestModel()));
                }

                return Get<List<SaleChannelViewModel>>(sessionName);
            }
        }
        internal void ClearSaleChannels()
        {
            Remove("SaleChannels");
        }
        #endregion



    }
}