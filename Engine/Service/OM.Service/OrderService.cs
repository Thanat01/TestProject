using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Service
{
    public class OrderService : IDisposable
    {
        private OM.Business.CustomerOrder _customerOrder;

        public OrderService(int shopId, int userId)
        {
            _customerOrder = new OM.Business.CustomerOrder(shopId, userId);
        }

        public List<PersonOrderModel> GetOrders()
        {
            try
            {
                return _customerOrder.GetOrders();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_customerOrder != null)
            {
                _customerOrder = null;
            }
        }

        #endregion
    }
}
