using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OStore.GlobalResources;

namespace OStore.Models.Product
{
    public class OrderProductViewModel
    {
        public OrderProductViewModel()
        {
            Colors = new List<System.Web.Mvc.SelectListItem>();
            Sizes = new List<System.Web.Mvc.SelectListItem>();
        }

        public int Id { get; set; }

        [Display(Name = @"Order_Manual_Product_SKU", ResourceType = typeof(StringResource))]
        public string SKU { get; set; }

        [Display(Name = @"Order_Manual_Product_Name", ResourceType = typeof(StringResource))]
        public string Name { get; set; }

        [Display(Name = @"Order_Manual_Product_StockQuantity", ResourceType = typeof(StringResource))]
        public int StockQuantity { get; set; }

        [Display(Name = @"Order_Manual_Product_Color", ResourceType = typeof(StringResource))]
        //[Required(ErrorMessage = @"Order_Manual_Product_Color_Required", ErrorMessageResourceType = typeof(StringResource))]
        public int ColorId { get; set; }

        [Display(Name = @"Order_Manual_Product_Size", ResourceType = typeof(StringResource))]
        //[Required(ErrorMessage = @"Order_Manual_Product_Size_Required", ErrorMessageResourceType = typeof(StringResource))]
        public int SizeId { get; set; }

        [Display(Name = @"Order_Manual_Product_Price", ResourceType = typeof(StringResource))]
        public decimal Price { get; set; }

        [Display(Name = @"Order_Manual_Product_OrderQuantity", ResourceType = typeof(StringResource))]
        //[Required(ErrorMessage = @"Order_Manual_Product_OrderQuantity_Required", ErrorMessageResourceType = typeof(StringResource))]
        public int OrderQuantity { get; set; }

        [Display(Name = @"Order_Manual_Product_Image", ResourceType = typeof(StringResource))]
        public string Image { get; set; }

        public List<System.Web.Mvc.SelectListItem> Colors { get; set; }
        public List<System.Web.Mvc.SelectListItem> Sizes { get; set; }
    }
}