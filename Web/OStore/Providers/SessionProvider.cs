using OStore.Models;
using OStore.Models.Customer;
using OStore.Models.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OStore.Models.Product;

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
        public List<FAQ> ShopFAQs
        {
            get
            {
                if (!IsExist("ShopFAQs"))
                {
                    Set<List<FAQ>>("ShopFAQs", null );
                }

                return Get<List<FAQ>>("ShopFAQs");
            }
            set { Set<List<FAQ>>("ShopFAQs", value); }
        }

        public List<TreeViewExampleModel> DummyDataTreeview
        {
            get
            {
                if (!IsExist("DummyDataTreeview"))
                {
                    List<TreeViewExampleModel> data = new List<TreeViewExampleModel>();
                    data.Add(new TreeViewExampleModel()
                    {
                        Checked = false,
                        Display = "Dress",
                        Id=1
                    });
                    data.Add(new TreeViewExampleModel()
                    {
                        Checked = false,
                        Display = "Shoes",
                        Id = 2
                    });
                    data.Add(new TreeViewExampleModel()
                    {
                        Checked = false,
                        Display = "Swimming",
                        Id = 3,
                        SubCategories = new List<TreeViewExampleModel>()
                        {
                            new TreeViewExampleModel()
                            {
                                Checked = false,
                                Display = "Men",
                                Id = 31
                            },new TreeViewExampleModel()
                            {
                                Checked = false,
                                Display = "Women",
                                Id = 32
                            },new TreeViewExampleModel()
                            {
                                Checked = false,
                                Display = "Kids",
                                Id = 33
                            },
                        }
                    });
                    data.Add(new TreeViewExampleModel()
                    {
                        Checked = false,
                        Display = "Shirts",
                        Id = 4
                    });

                    Set<List<TreeViewExampleModel>>("DummyDataTreeview", data);
                }

                return Get<List<TreeViewExampleModel>>("DummyDataTreeview");
            }
            set { Set<List<TreeViewExampleModel>>("DummyDataTreeview", value); }
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