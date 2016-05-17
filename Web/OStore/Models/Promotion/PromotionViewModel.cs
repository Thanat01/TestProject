using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class PromotionViewModel
    {
        public PromotionViewModel()
        {
            DiscountTypes = new List<System.Web.Mvc.SelectListItem>();
            DiscountTypes.Add(new System.Web.Mvc.SelectListItem() { Value = "Amount", Text = "Amount" });
            DiscountTypes.Add(new System.Web.Mvc.SelectListItem() { Value = "Percentage", Text = "Percentage" });
        }

        public int Id { get; set; }
        public Nullable<int> ShopId { get; set; }

        [Display(Name = @"Marketing_Promotion_Code", ResourceType = typeof(StringResource))]
        public string Code { get; set; }

        [Display(Name = @"Marketing_Promotion_Name", ResourceType = typeof(StringResource))]
        public string Name { get; set; }

        [Display(Name = @"Marketing_Promotion_UsedQuantity", ResourceType = typeof(StringResource))]
        public int? UsedQuantity { get; set; }

        [Display(Name = @"Marketing_Promotion_DiscountType", ResourceType = typeof(StringResource))]
        public Nullable<int> DiscountTypeId { get; set; }
        public List<System.Web.Mvc.SelectListItem> DiscountTypes { get; set; }

        [Display(Name = @"Marketing_Promotion_Amount", ResourceType = typeof(StringResource))]
        public Nullable<decimal> Amount { get; set; }

        [Display(Name = @"Marketing_Promotion_Percentage", ResourceType = typeof(StringResource))]
        public Nullable<decimal> Percentage { get; set; }

        [Display(Name = @"Marketing_Promotion_MinimumPurchase", ResourceType = typeof(StringResource))]
        public Nullable<decimal> MinimumPurchase { get; set; }

        [Display(Name = @"Marketing_Promotion_MaximumDiscount", ResourceType = typeof(StringResource))]
        public Nullable<decimal> MaximumDiscount { get; set; }

        [Display(Name = @"Marketing_Promotion_MinimunItem", ResourceType = typeof(StringResource))]
        public Nullable<int> MinimumItem { get; set; }

        [Display(Name = @"Marketing_Promotion_LimitPerCustomer", ResourceType = typeof(StringResource))]
        public Nullable<int> LimitPerCustomer { get; set; }

        [Display(Name = @"Marketing_Promotion_LimitTotal", ResourceType = typeof(StringResource))]
        public Nullable<int> LimitTotal { get; set; }

        [Display(Name = @"Marketing_Promotion_EffectiveDate", ResourceType = typeof(StringResource))]
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        [Display(Name = @"Marketing_Promotion_EffectiveTime", ResourceType = typeof(StringResource))]
        public Nullable<System.DateTime> EffectiveTime { get; set; }

        [Display(Name = @"Marketing_Promotion_ExpiredDate", ResourceType = typeof(StringResource))]
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        [Display(Name = @"Marketing_Promotion_ExpiredTime", ResourceType = typeof(StringResource))]
        public Nullable<System.DateTime> ExpiryTime { get; set; }

        [Display(Name = @"Marketing_Promotion_IsActive", ResourceType = typeof(StringResource))]
        public bool IsActive { get; set; }
    }
}