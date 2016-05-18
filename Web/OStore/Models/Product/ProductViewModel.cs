using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.Product
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Tags = new List<string>();
        }

        public int Id { get; set; }
        public int ShopId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<int> ProductItems { get; set; }
        public List<int> Categories { get; set; }
        public List<string> Tags { get; set; }
    }
}