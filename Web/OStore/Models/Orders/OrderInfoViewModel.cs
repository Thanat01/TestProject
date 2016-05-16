using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Orders
{
    public class OrderInfoViewModel
    {
        [Display(Name = @"OrderManagement_Pay_OrderId", ResourceType = typeof(StringResource))]
        public string OrderId { get; set; }

        [Display(Name = @"OrderManagement_Pay_OrderDate", ResourceType = typeof(StringResource))]
        public DateTime OrderDate { get; set; }

        [Display(Name = @"OrderManagement_Pay_TimeLap", ResourceType = typeof(StringResource))]
        public string TimeLaps { get; set; }

        [Display(Name = @"OrderManagement_Pay_CustomerName", ResourceType = typeof(StringResource))]
        public string CustomerName { get; set; }

        [Display(Name = @"OrderManagement_Pay_Mobile", ResourceType = typeof(StringResource))]
        public string Mobile { get; set; }

        [Display(Name = @"OrderManagement_Pay_Line", ResourceType = typeof(StringResource))]
        public string Line { get; set; }

        [Display(Name = @"OrderManagement_Pay_Price", ResourceType = typeof(StringResource))]
        public decimal Price { get; set; }

        [Display(Name = @"OrderManagement_Pay_StatusId", ResourceType = typeof(StringResource))]
        public string StatusId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Statuses { get; set; }

        [Display(Name = @"OrderManagement_Pay_Reason", ResourceType = typeof(StringResource))]
        public string Reason { get; set; }

        [Display(Name = @"OrderManagement_Pay_StoreStaff", ResourceType = typeof(StringResource))]
        public string StoreStaff { get; set; }

        [Display(Name = @"OrderManagement_Pay_ItemLine", ResourceType = typeof(StringResource))]
        public string ItemLine { get; set; }

        [Display(Name = @"OrderManagement_Pay_ItemCode", ResourceType = typeof(StringResource))]
        public string ItemCode { get; set; }

        [Display(Name = @"OrderManagement_Pay_ItemDescription", ResourceType = typeof(StringResource))]
        public string ItemDescription { get; set; }

        [Display(Name = @"OrderManagement_Pay_Remark", ResourceType = typeof(StringResource))]
        public string Remark { get; set; }
    }
}