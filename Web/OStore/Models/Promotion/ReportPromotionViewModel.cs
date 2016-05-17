using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.Promotion
{
    public class ReportPromotionViewModel
    {
        public ReportPromotionViewModel() { Orders = new List<PromotionOrderViewModel>(); }
        public string PromotionCode { get; set; }
        public List<PromotionOrderViewModel> Orders { get; set; }
    }

    public class PromotionOrderViewModel
    {
        public int No { get; set; }
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Revenue { get; set; }
        public string Status { get; set; }
    }
}