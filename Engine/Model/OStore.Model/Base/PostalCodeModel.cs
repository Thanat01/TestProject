using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Model.Base
{
    [Serializable]
    public class PostalCodeModel
    {
        public int Id { get; set; }
        public Nullable<int> SubDistrictId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
