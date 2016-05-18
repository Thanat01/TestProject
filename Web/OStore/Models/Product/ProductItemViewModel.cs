using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Product
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [Display(Name = @"Product_Create_Item_SKU", ResourceType = typeof(StringResource))]
        public string SKU { get; set; }

        [Display(Name = @"Product_Create_Item_MFSKU", ResourceType = typeof(StringResource))]
        public string MFSKU { get; set; }

        [Display(Name = @"Product_Create_Item_UNSKU", ResourceType = typeof(StringResource))]
        public string UNSKU { get; set; }

        [Display(Name = @"Product_Create_Item_Size", ResourceType = typeof(StringResource))]
        public string Size { get; set; }

        [Display(Name = @"Product_Create_Item_Color", ResourceType = typeof(StringResource))]
        public string Color { get; set; }

        [Display(Name = @"Product_Create_Item_Material", ResourceType = typeof(StringResource))]
        public string Material { get; set; }

        [Display(Name = @"Product_Create_Item_Cost", ResourceType = typeof(StringResource))]
        public decimal Cost { get; set; }

        [Display(Name = @"Product_Create_Item_Price", ResourceType = typeof(StringResource))]
        public decimal Price { get; set; }

        [Display(Name = @"Product_Create_Item_SpecialPrice", ResourceType = typeof(StringResource))]
        public decimal SpecialPrice { get; set; }

        public int OnHandQuantity { get; set; }

        [Display(Name = @"Product_Create_Item_Quantity", ResourceType = typeof(StringResource))]
        public int OrderQuantity { get; set; }
    }
}