using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Providers;

namespace OStore.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string AddressLine01 { get; set; }

        public int? ProvinceId { get; set; }
        private List<SelectListItem> _province;
        public List<SelectListItem> Provinces
        {
            get { return _province ?? (_province = CacheProvider.Instance.Provinces); }
            set
            {
                _province = value;
            }
        }

        public int? DistrictId { get; set; }
        private List<SelectListItem> _district;
        public List<SelectListItem> Districts
        {
            get { return _district ?? (_district = CacheProvider.Instance.Districts); }
            set
            {
                _district = value;
            }
        }

        public int? SubDistrictId { get; set; }
        private List<SelectListItem> _subdistrict;
        public List<SelectListItem> SubDistricts
        {
            get { return _subdistrict ?? (_subdistrict = CacheProvider.Instance.SubDistricts); }
            set
            {
                _subdistrict = value;
            }
        }

        public string PostCode { get; set; }
        private List<SelectListItem> _postalCode;
        public List<SelectListItem> PostalCodes
        {
            get { return _postalCode ?? (_postalCode = CacheProvider.Instance.PostalCodes); }
            set
            {
                _postalCode = value;
            }
        }

        public string Mobile { get; set; }
        public string Email { get; set; }
        public string FaceBookId { get; set; }
        public string LineId { get; set; }
        public string InstagramId { get; set; }

        public string Logo { get; set; }

        [AllowHtml]
        public string AboutUs { get; set; }
        //public List<KeyValuePair<string,string>> FAQs { get; set; }
        public FAQ Faq { get; set; }

        private List<FAQ> _listOfFAQs;
        public List<FAQ> ListOfFAQs
        {
            get { return _listOfFAQs ?? (_listOfFAQs = SessionProvider.Instance.ShopFAQs); }
            set
            {
                _listOfFAQs = value;
            }
        }
        private List<TreeViewExampleModel> _treeview;
        public List<TreeViewExampleModel> TreeViewExamples
        {
            get
            {
                if(_treeview==null)
                {
                    _treeview = SessionProvider.Instance.DummyDataTreeview;
                    
                }
                return _treeview;
            }
            set
            {
                _treeview = value;
            }


        }
    }
    public class FAQ
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
    public class TreeViewExampleModel
    {
        public string Display { get; set; }
        public bool Checked { get; set; }
        public int Id { get; set; }

       // private List<TreeViewExampleModel> _sub;
        public List<TreeViewExampleModel> SubCategories { get; set; }
        //{
        //    get { return _sub ?? (_sub = new List<TreeViewExampleModel>()); }
        //    set
        //    {
        //        _sub = value;
        //    }


        //}
    }
}