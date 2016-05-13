using Library.Api.Model;
using OStore.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    [Serializable]
    public class GetProvinceRequestModel
    {

    }
    [Serializable]
    public class GetProvinceResponseModel : ResponseModelBase
    {
        public GetProvinceResponseModel(MessageCode code, string message) : base(code, message) { Provinces = new List<ProvinceModel>(); }
        public List<ProvinceModel> Provinces { get; set; }
    }

    [Serializable]
    public class GetDistrictRequestModel
    {

    }
    [Serializable]
    public class GetDistrictResponseModel : ResponseModelBase
    {
        public GetDistrictResponseModel(MessageCode code, string message) : base(code, message) { Districts = new List<DistrictModel>(); }
        public List<DistrictModel> Districts { get; set; }
    }

    [Serializable]
    public class GetSubDistrictRequestModel
    {

    }
    [Serializable]
    public class GetSubDistrictResponseModel : ResponseModelBase
    {
        public GetSubDistrictResponseModel(MessageCode code, string message) : base(code, message) { SubDistricts = new List<SubDistrictModel>(); }
        public List<SubDistrictModel> SubDistricts { get; set; }
    }

    [Serializable]
    public class GetPostalCodeRequestModel
    {

    }
    [Serializable]
    public class GetPostalCodeResponseModel : ResponseModelBase
    {
        public GetPostalCodeResponseModel(MessageCode code, string message) : base(code, message) { PostalCodes = new List<PostalCodeModel>(); }
        public List<PostalCodeModel> PostalCodes { get; set; }
    }
}