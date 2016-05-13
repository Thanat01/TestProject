using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Model.Base
{
    public class ShopPaymentAccountModel
    {
        public int Id { get; set; }
        public int ShopMapPaymentChannelId { get; set; }
        public string Account { get; set; }
        public Nullable<int> BankId { get; set; }
        public string Branch { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
