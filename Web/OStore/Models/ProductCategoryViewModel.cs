using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public Nullable<int> ShopId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PrimaryImageURL { get; set; }
        public string SecondaryImageURL { get; set; }
        public Nullable<int> PrimaryBoxSeq { get; set; }
        public Nullable<int> SecondaryBoxSeq { get; set; }
        public Nullable<int> Seq { get; set; }
        public Nullable<bool> Published { get; set; }
        public bool IsActive { get; set; }
    }
}