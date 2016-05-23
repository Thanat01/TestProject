using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Orders
{
    public class ConfirmPackOrderViewModel
    {
        [Display(Name = @"OrderManagement_Pack_OrderId", ResourceType = typeof(StringResource))]
        public string OrderId { get; set; }

        [Display(Name = @"OrderManagement_Pack_CustomerName", ResourceType = typeof(StringResource))]
        public string CustomerName { get; set; }

        [Display(Name = @"OrderManagement_Pack_TrackingNumber", ResourceType = typeof(StringResource))]
        public string TrackingNumber { get; set; }
    }
}