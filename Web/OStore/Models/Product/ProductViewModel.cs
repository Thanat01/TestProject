using GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Product
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            ProductItems = new List<ProductItemViewModel>();
            Tags = new List<string>();
        }

        public int Id { get; set; }
        public int ShopId { get; set; }
        public string SKU { get; set; }

        [Display(Name = @"Product_Create_Name", ResourceType = typeof(StringResource))]
        public string Name { get; set; }

        [Display(Name = @"Product_Create_Description", ResourceType = typeof(StringResource))]
        public string Description { get; set; }

        [Display(Name = @"Product_Create_Cost", ResourceType = typeof(StringResource))]
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }

        [Display(Name = @"Product_Create_Price", ResourceType = typeof(StringResource))]
        public decimal Price { get; set; }

        [Display(Name = @"Product_Create_SpecialPrice", ResourceType = typeof(StringResource))]
        public decimal SpecialPrice { get; set; }

        [Display(Name = @"Product_Create_PrepareDate", ResourceType = typeof(StringResource))]
        public int PrepareDate { get; set; }

        [Display(Name = @"Product_Create_ShowWhenOutStock", ResourceType = typeof(StringResource))]
        public bool ShowWhenOutStock { get; set; }

        [Display(Name = @"Product_Create_IsActive", ResourceType = typeof(StringResource))]
        public bool IsActive { get; set; }

        public List<ProductItemViewModel> ProductItems { get; set; }

        public List<int> Categories { get; set; }

        [Display(Name = @"Product_Create_Tag", ResourceType = typeof(StringResource))]
        public List<string> Tags { get; set; }
    }
}