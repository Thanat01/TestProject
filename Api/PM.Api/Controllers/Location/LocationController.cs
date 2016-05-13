using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Location
{
    public class LocationController: Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.LocationService _locationService;

        public LocationController() { _locationService = new Service.LocationService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetProvinces")]
        public GetProvinceResponseModel GetProvinces(GetProvinceRequestModel requestModel)
        {
            try
            {
                GetProvinceResponseModel responseModel = new GetProvinceResponseModel(MessageCode.OK, "");
                responseModel.Provinces = _locationService.GetProvinces();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetProvinceResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("GetDistricts")]
        public GetDistrictResponseModel GetDistricts(GetDistrictRequestModel requestModel)
        {
            try
            {
                GetDistrictResponseModel responseModel = new GetDistrictResponseModel(MessageCode.OK, "");
                responseModel.Districts = _locationService.GetDistricts();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetDistrictResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("GetSubDistricts")]
        public GetSubDistrictResponseModel GetSubDistricts(GetSubDistrictRequestModel requestModel)
        {
            try
            {
                GetSubDistrictResponseModel responseModel = new GetSubDistrictResponseModel(MessageCode.OK, "");
                responseModel.SubDistricts = _locationService.GetSubDistrict();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetSubDistrictResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("GetPostalCodes")]
        public GetPostalCodeResponseModel GetPostalCodes(GetPostalCodeRequestModel requestModel)
        {
            try
            {
                GetPostalCodeResponseModel responseModel = new GetPostalCodeResponseModel(MessageCode.OK, "");
                responseModel.PostalCodes = _locationService.GetPostalCodes();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetPostalCodeResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
