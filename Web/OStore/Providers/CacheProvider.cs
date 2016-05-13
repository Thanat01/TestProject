using OStore.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Libs.Extensions;
using OStore.Models.Delivery;

namespace OStore.Providers
{
    public class CacheProvider:Library.Api.Handler.CacheHandler 
    {
        private static CacheProvider _Instance;
        public static CacheProvider Instance
        {
            get { return _Instance ?? (_Instance = new CacheProvider()); }
        }

        #region Location
        public List<SelectListItem> Provinces
        {
            get
            {
                if (!IsIncache("Provinces"))
                {
                    List<ProvinceModel> provincs = PMApi.Instance.GetProvinces();

                    var cached = provincs.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select Provinces", false);
                        if (cached != null)
                        {
                            cached.RemoveAll(item => item.Text == null);
                            SaveTocache("Provinces", cached, DateTime.Now.AddHours(10));
                        }
                    
                }
                return GetFromCache<List<SelectListItem>>("Provinces");
            }
        }

        public List<SelectListItem> Districts
        {
            get
            {
                if (!IsIncache("Districts"))
                {
                    List<DistrictModel> districts = PMApi.Instance.GetDistricts();

                    var cached = districts.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select Districts", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("Districts", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("Districts");
            }
        }

        public List<SelectListItem> SubDistricts
        {
            get
            {
                if (!IsIncache("SubDistricts"))
                {
                    List<SubDistrictModel> subDistricts = PMApi.Instance.GetSubDistricts();

                    var cached = subDistricts.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select SubDistricts", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("SubDistricts", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("SubDistricts");
            }
        }

        public List<SelectListItem> PostalCodes
        {
            get
            {
                if (!IsIncache("PostalCodes"))
                {
                    List<PostalCodeModel> postalCodes = PMApi.Instance.GetPostalCodes();

                    var cached = postalCodes.ToSelectList(d => d.Code, d => d.Id.ToString(), "0", "Select PostalCodes", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("PostalCodes", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("PostalCodes");
            }
        }
        #endregion

        #region Delivery
        public List<SelectListItem> DeliveryChannels
        {
            get
            {
                if (!IsIncache("DeliveryChannels"))
                {
                    List<DeliveryChannelModel> postalCodes = PMApi.Instance.GetDeliveryChannels(new ModelApi.GetDeliveryChannelRequestModel());

                    var cached = postalCodes.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select DeliveryChannels", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("DeliveryChannels", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("DeliveryChannels");
            }
        }
        public List<CheckBox> Delivery1OptionsCheckbox
        {
            get
            {

                if (!IsIncache("Delivery1OptionsCheckbox"))
                {
                    List<CheckBox> options = new List<CheckBox>();
                    options.Add(new CheckBox()
                    {
                        Checked = false,
                        Text = "COD (Cash on Delivery)",
                        Value = "COD"
                    });
                    options.Add(new CheckBox()
                    {
                        Checked = false,
                        Text = "Bank Transfer",
                        Value = "BT"
                    });
                    options.Add(new CheckBox()
                    {
                        Checked = false,
                        Text = "Appointment Time",
                        Value = "AT"
                    });

                    SaveTocache("Delivery1OptionsCheckbox", options, DateTime.Now.AddHours(10));
                    // var roles = _roleService.GetAllRoles().ToCheckBoxList(c => c.Name, c => c.Id.ToString());
                    //if (roles != null)
                    //{
                    //    SaveTocache("DeliveryOptionsCheckbox", roles, DateTime.Now.AddHours(10));
                    //}
                }
                return GetFromCache<List<CheckBox>>("Delivery1OptionsCheckbox");

            }
        }

        public List<CheckBox> Delivery2OptionsCheckbox
        {
            get
            {

                if (!IsIncache("Delivery2OptionsCheckbox"))
                {
                    List<CheckBox> options = new List<CheckBox>();

                    options.Add(new CheckBox()
                    {
                        Checked = false,
                        Text = "Bank Transfer",
                        Value = "BT"
                    });

                    SaveTocache("Delivery2OptionsCheckbox", options, DateTime.Now.AddHours(10));
                    // var roles = _roleService.GetAllRoles().ToCheckBoxList(c => c.Name, c => c.Id.ToString());
                    //if (roles != null)
                    //{
                    //    SaveTocache("DeliveryOptionsCheckbox", roles, DateTime.Now.AddHours(10));
                    //}
                }
                return GetFromCache<List<CheckBox>>("Delivery2OptionsCheckbox");

            }
        }
        #endregion
    }
}