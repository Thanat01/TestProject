using OStore.GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.SaleChannel
{
    public class ImportOrderViewModel
    {
        public ImportOrderViewModel()
        {
            Sources = new List<System.Web.Mvc.SelectListItem>();
            Sources.Add(new System.Web.Mvc.SelectListItem() { Text = "Lazada", Value = "Lazada" });
            Sources.Add(new System.Web.Mvc.SelectListItem() { Text = "Shoppee", Value = "Shoppee" });
            Sources.Add(new System.Web.Mvc.SelectListItem() { Text = "Manual", Value = "Manual" });

            Orders = new List<ImportOrderModel>();
        }

        [Display(Name = @"Order_Import_Source", ResourceType = typeof(StringResource))]
        public string SourceId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Sources { get; set; }

        public List<ImportOrderModel> Orders { get; set; }
    }

    public class ImportOrderModel
    {
        public string OrderId { get; set; }
        public string RefId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Revenue { get; set; }
        public string Status { get; set; }
    }
}