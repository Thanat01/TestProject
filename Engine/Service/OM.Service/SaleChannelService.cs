using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Service
{
    public class SaleChannelService: IDisposable
    {
        private OM.Business.SaleChannel _saleChannel;

        public SaleChannelService(int shopId, int userId)
        {
            _saleChannel = new OM.Business.SaleChannel(shopId, userId);
        }

        public List<SaleChannelModel> GetSaleChannels()
        {
            try
            {
                return _saleChannel.GetSaleChannels();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_saleChannel != null)
            {
                _saleChannel = null;
            }
        }

        #endregion
    }
}
