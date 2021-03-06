//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OStore.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class ProductMapProduct
    {
        public int ShopId { get; set; }
        public int ProductId1 { get; set; }
        public int ProductId2 { get; set; }
        public int ProductRelationTypeId { get; set; }
        public Nullable<int> Seq { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ProductRelationType ProductRelationType { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
