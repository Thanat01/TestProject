using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string DNS { get; set; }
        public string AddressLine01 { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubDistrictId { get; set; }
        public string PostCode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string FaceBookId { get; set; }
        public string LineId { get; set; }
        public string InstargramId { get; set; }
        public string Vision { get; set; }
        public string TimZoneId { get; set; }
        public bool IsActive { get; set; }
        public string Logo { get; set; }
    }
}