using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Providers
{
    public class SessionProvider:Library.Api.Handler.SessionHandler
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
    }
}