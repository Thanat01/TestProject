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

        ////private List<KeyValuePair<string, string>> _faqs;
        //public List<KeyValuePair<string, string>> FAQs
        //{
        //    get { return _faqs ?? (_faqs = SessionProvider.Instance.ShopFAQs); }
        //    set
        //    {
        //        _faqs = value;
        //    }
        //}

        //private KeyValuePair<string, string> _faq;
        //public KeyValuePair<string, string> FAQ
        //{
        //    get { return _faq; }
        //    set { _faq = value; }
        //}

        //public string _faqKey
        //{
        //    get { return _faq.Key; }
        //    set { _faq = new KeyValuePair<string, string>(value, _faq.Value); }
        //}

        //public string _faqValue
        //{
        //    get { return _faq.Value; }
        //    set { _faq = new KeyValuePair<string, string>(_faq.Key, value); }
        //}
        //public string DNS { get; set; }
        //public string Vision { get; set; }
        //public string TimZoneId { get; set; }
        //public bool IsActive { get; set; }
    }
    public class FAQ
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}