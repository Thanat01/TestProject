using OStore.GlobalResources;
using OStore.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.SaleChannel
{
    public class OrderManualViewModel
    {
        public OrderManualViewModel()
        {
            Products = new List<OrderProductViewModel>();
            DeliveryChannels = new List<System.Web.Mvc.SelectListItem>();
        }

        [Display(Name = @"Order_Manual_OrderId", ResourceType = typeof(StringResource))]
        public string OrderId { get; set; }

        [Display(Name = @"Order_Manual_Link", ResourceType = typeof(StringResource))]
        public string RegisterLink { get; set; }

        [Display(Name = @"Order_Manual_OrderDate", ResourceType = typeof(StringResource))]
        public DateTime OrderDate { get; set; }

        [Display(Name = @"Order_Manual_Status", ResourceType = typeof(StringResource))]
        public string Status { get; set; }

        [Display(Name = @"Order_Manual_CustomerId", ResourceType = typeof(StringResource))]
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //[Required(ErrorMessage = @"Order_Manual_Quantity_Required", ErrorMessageResourceType = typeof(StringResource))]
        [Required(ErrorMessageResourceType = typeof(StringResource), ErrorMessageResourceName = @"Order_Manual_Quantity_Required")]
        [Display(Name = @"Order_Manual_Quantity", ResourceType = typeof(StringResource))]
        public int Quantity { get; set; }

        [Display(Name = @"Order_Manual_TotalAmount", ResourceType = typeof(StringResource))]
        public decimal TotalAmount { get; set; }

        [Display(Name = @"Order_Manual_DeliveryChannel", ResourceType = typeof(StringResource))]
        public int DeliveryChannelId { get; set; }
        public List<System.Web.Mvc.SelectListItem> DeliveryChannels { get; set; }

        public decimal DeliveryAmount { get; set; }

        [Display(Name = @"Order_Manual_DiscountAmount", ResourceType = typeof(StringResource))]
        public decimal DiscountAmount { get; set; }

        [Display(Name = @"Order_Manual_GrandTotalAmount", ResourceType = typeof(StringResource))]
        public decimal GrandTotalAmount { get; set; }

        [Display(Name = @"Order_Manual_Remark", ResourceType = typeof(StringResource))]
        public string Remark { get; set; }

        [Display(Name = @"Order_Manual_ProductList", ResourceType = typeof(StringResource))]
        public List<OrderProductViewModel> Products { get; set; }
    }
}