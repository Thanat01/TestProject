using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PageURL { get; set; }
        public string IconURL { get; set; }
        public Nullable<int> Seq { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}