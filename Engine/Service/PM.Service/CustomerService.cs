using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class CustomerService: IDisposable
    {

        private PM.Business.Customer _customer;

        public CustomerService(int shopId, int userId)
        {
            _customer = new Business.Customer(shopId, userId);
        }

        public List<OStore.Model.CustomerInfoModel> GetCustomers()
        {
            try
            {
                return _customer.GetCustomers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCustomers(List<OStore.Model.CustomerInfoModel> customers)
        {
            try
            {
                _customer.UpdateCustomers(customers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_customer != null)
            {
                _customer = null;
            }
        }

        #endregion
    }
}
