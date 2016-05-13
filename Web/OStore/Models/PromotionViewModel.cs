using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class PromotionViewModel
    {
        public int Id { get; set; }
        public Nullable<int> ShopId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UsedQuantity { get; set; }
        public Nullable<int> DiscountTypeId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<int> LimitTotal { get; set; }
        public Nullable<int> LimitPerCustomer { get; set; }
        public Nullable<decimal> MinimumPurchase { get; set; }
        public Nullable<decimal> MaximumDiscount { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public bool IsActive { get; set; }
    }
}