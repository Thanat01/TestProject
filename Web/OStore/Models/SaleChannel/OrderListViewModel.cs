using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.SaleChannel
{
    public class OrderListViewModel
    {
        public OrderListViewModel()
        {
            Statuses = new List<System.Web.Mvc.SelectListItem>();
            Statuses.Add(new System.Web.Mvc.SelectListItem() { Value = "1", Text = "Pending" });
            Statuses.Add(new System.Web.Mvc.SelectListItem() { Value = "2", Text = "Confirm" });
            Statuses.Add(new System.Web.Mvc.SelectListItem() { Value = "3", Text = "Cancel" });
        }

        [Display(Name = @"Order_List_OrderId", ResourceType = typeof(StringResource))]
        public string OrderId { get; set; }

        [Display(Name = @"Order_List_OrderDate", ResourceType = typeof(StringResource))]
        public DateTime OrderDate { get; set; }

        [Display(Name = @"Order_List_CustomerId", ResourceType = typeof(StringResource))]
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [Display(Name = @"Order_List_Mobile", ResourceType = typeof(StringResource))]
        public string Mobile { get; set; }

        [Display(Name = @"Order_List_Address", ResourceType = typeof(StringResource))]
        public string Address { get; set; }

        [Display(Name = @"Order_List_Status", ResourceType = typeof(StringResource))]
        public string StatusId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Statuses { get; set; }

        [Display(Name = @"Order_List_Email", ResourceType = typeof(StringResource))]
        public string Email { get; set; }

        [Display(Name = @"Order_List_PaymentType", ResourceType = typeof(StringResource))]
        public string PaymentType { get; set; }
    }
}