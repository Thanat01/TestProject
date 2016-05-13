using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class DeliveryService: IDisposable
    {

        private PM.Business.Delivery _delivery;

        public DeliveryService(int shopId, int userId)
        {
            _delivery = new Business.Delivery(shopId, userId);
        }

        public List<OStore.Model.Base.DeliveryChannelModel> GetDeliveryChannels()
        {
            try
            {
                return _delivery.GetDeliveryChannels();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
                #region IDisposable Members

        public void Dispose()
        {
            if (_delivery != null)
            {
                _delivery = null;
            }
        }

        #endregion
    }
}
