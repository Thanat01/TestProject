using GlobalResources;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = @"Marketing_Customer_Picture", ResourceType = typeof(StringResource))]
        public string PictureURL { get; set; }

        [Display(Name = @"Marketing_Customer_Firstname", ResourceType = typeof(StringResource))]
        public string Firstname { get; set; }

        [Display(Name = @"Marketing_Customer_Lastname", ResourceType = typeof(StringResource))]
        public string Lastname { get; set; }

        [Display(Name = @"Marketing_Customer_Nickname", ResourceType = typeof(StringResource))]
        public string Nickname { get; set; }

        [Display(Name = @"Marketing_Customer_Mobile", ResourceType = typeof(StringResource))]
        public string Mobile { get; set; }

        [Display(Name = @"Marketing_Customer_Email", ResourceType = typeof(StringResource))]
        public string Email { get; set; }

        [Display(Name = @"Marketing_Customer_Facebook", ResourceType = typeof(StringResource))]
        public string Facebook { get; set; }

        [Display(Name = @"Marketing_Customer_Line", ResourceType = typeof(StringResource))]
        public string Line { get; set; }

        [Display(Name = @"Marketing_Customer_Instargram", ResourceType = typeof(StringResource))]
        public string Instargram { get; set; }

        [Display(Name = @"Marketing_Customer_Address", ResourceType = typeof(StringResource))]
        public string Address { get; set; }

        [Display(Name = @"Marketing_Customer_Province", ResourceType = typeof(StringResource))]
        public int? ProvinceId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Provinces { get; set; }

        [Display(Name = @"Marketing_Customer_District", ResourceType = typeof(StringResource))]
        public int? DistrictId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Districts { get; set; }

        [Display(Name = @"Marketing_Customer_SubDistrict", ResourceType = typeof(StringResource))]
        public int? SubDistrictId { get; set; }
        public List<System.Web.Mvc.SelectListItem> SubDistricts { get; set; }

        [Display(Name = @"Marketing_Customer_PostalCode", ResourceType = typeof(StringResource))]
        public int? PostalCodeId { get; set; }
        public List<System.Web.Mvc.SelectListItem> PostalCodes { get; set; }

        [Display(Name = @"Marketing_Customer_IsActive", ResourceType = typeof(StringResource))]
        public bool IsActive { get; set; }

    }
}