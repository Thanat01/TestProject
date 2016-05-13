using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class PaymentChannelModel
    {
        public PaymentChannelModel() { Accounts = new List<BankAccountModel>(); }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Seq { get; set; }
        public bool IsActive { get; set; }

        public List<BankAccountModel> Accounts { get; set; }
    }
}