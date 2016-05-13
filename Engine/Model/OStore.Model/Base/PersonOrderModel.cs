using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Model.Base
{
    public class PersonOrderModel
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> PromotionId { get; set; }
        public Nullable<decimal> NetPrice { get; set; }
        public Nullable<int> CustomerAddressId { get; set; }
        public Nullable<int> OrderStatusId { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
