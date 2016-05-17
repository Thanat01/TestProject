using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Orders
{
    public class SearchConditionViewModel
    {
        public SearchConditionViewModel()
        {
            SaleChannels = new List<System.Web.Mvc.SelectListItem>();
            Provinces = new List<System.Web.Mvc.SelectListItem>();
        }
        [Display(Name = @"OrderManagement_Pay_SaleChannelId", ResourceType = typeof(StringResource))]
        public int SaleChannelId { get; set; }
        public List<System.Web.Mvc.SelectListItem> SaleChannels { get; set; }

        [Display(Name = @"OrderManagement_Pay_Geography", ResourceType = typeof(StringResource))]
        public int ProvinceId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Provinces { get; set; }

        [Display(Name = @"OrderManagement_Pay_OrderDateFrom", ResourceType = typeof(StringResource))]
        [DataType(DataType.Date)]
        public DateTime OrderDateFrom { get; set; }

        [Display(Name = @"OrderManagement_Pay_OrderDateTo", ResourceType = typeof(StringResource))]
        [DataType(DataType.Date)]
        public DateTime OrderDateTo { get; set; }

        [Display(Name = @"OrderManagement_Pay_CutOffTime", ResourceType = typeof(StringResource))]
        [DataType(DataType.Time)]
        public DateTime CutOffTime { get; set; }

        [Display(Name = @"OrderManagement_Pay_PickUpTime", ResourceType = typeof(StringResource))]
        [DataType(DataType.Time)]
        public DateTime PickupTime { get; set; }

    }
}