using OStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Service
{
    public class ShopService : IDisposable
    {
        private AT.Business.Shop _shop;

        public ShopService(int shopId, int userId)
        {
            _shop = new Business.Shop(shopId, userId);
        }

        public ShopInfoModel GetShopInfo(string dns)
        {
            try
            {
                return _shop.GetShopInfo(dns);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void UpdateShopInfo(ShopInfoModel model)
        {
            try
            {
                if (model.Id <= 0)
                    _shop.AddNewShopInfo(model);
                else
                    _shop.UpdateShopInfo(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_shop != null)
                _shop = null;
        }

        #endregion


    }
}
