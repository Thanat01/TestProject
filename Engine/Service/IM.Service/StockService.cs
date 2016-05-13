using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Service
{
    public class StockService: IDisposable
    {

        private IM.Business.Stock _product;

        public StockService(int shopId, int userId)
        {
            _product = new Business.Stock(shopId, userId);
        }

        public List<OStore.Model.StockModel> GetStocks(int? categoryId)
        {
            try
            {
                return _product.GetStocks(categoryId ?? 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_product != null)
            {
                _product = null;
            }
        }

        #endregion
    }
}
