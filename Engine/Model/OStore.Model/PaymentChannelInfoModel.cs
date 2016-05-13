using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Model
{
    public class PaymentChannelInfoModel : PaymentChannelModel
    {
        public PaymentChannelInfoModel() { Accounts = new List<ShopPaymentAccountModel>(); }
        public List<ShopPaymentAccountModel> Accounts { get; set; }
    }
}
