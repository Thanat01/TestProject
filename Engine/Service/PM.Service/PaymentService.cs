using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class PaymentService : IDisposable
    {
        private PM.Business.Payment _payment;

        public PaymentService(int shopId, int userId)
        {
            _payment = new Business.Payment(shopId, userId);
        }

        public List<OStore.Model.PaymentChannelInfoModel> GetPayments()
        {
            try
            {
                return _payment.GetPayments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePayments(List<OStore.Model.PaymentChannelInfoModel> payments)
        {
            try
            {
                _payment.UpdatePayments(payments);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_payment != null)
            {
                _payment = null;
            }
        }

        #endregion

    }
}
