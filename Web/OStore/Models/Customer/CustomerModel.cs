using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.Customer
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            Provinces = new List<System.Web.Mvc.SelectListItem>();
            Provinces.AddRange(CacheProvider.Instance.Provinces);

            Districts = new List<System.Web.Mvc.SelectListItem>();
            Districts.AddRange(CacheProvider.Instance.Districts);

            SubDistricts = new List<System.Web.Mvc.SelectListItem>();
            SubDistricts.AddRange(CacheProvider.Instance.SubDistricts);

            PostalCodes = new List<System.Web.Mvc.SelectListItem>();
            PostalCodes.AddRange(CacheProvider.Instance.PostalCodes);
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? ProvinceId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Provinces { get; set; }
        public int? DistrictId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Districts { get; set; }
        public int? SubDistrictId { get; set; }
        public List<System.Web.Mvc.SelectListItem> SubDistricts { get; set; }
        public int? PostalCodeId { get; set; }
        public List<System.Web.Mvc.SelectListItem> PostalCodes { get; set; }
        public bool IsActive { get; set; }

    }
}