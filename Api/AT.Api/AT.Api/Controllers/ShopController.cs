using AT.Api.Models;
using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AT.Api.Controllers
{
    public class ShopController : Library.Api.Controller.Base.ApiControllerBase
    {
        AT.Service.ShopService _shopService;
        public ShopController() { _shopService = new Service.ShopService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetShopInfo")]
        public ShopInfoResponseModel GetShopInfo(ShopInfoRequestModel request)
        {
            try
            {
                ShopInfoResponseModel response = new ShopInfoResponseModel(MessageCode.OK, "") { Shop = _shopService.GetShopInfo(request.DNS) };

                return response;
            }
            catch (Exception ex)
            {
                return new ShopInfoResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdateShopInfo")]
        public UpdateShopInfoResponseModel UpdateShopInfo(UpdateShopInfoRequestModel request)
        {
            try
            {
                UpdateShopInfoResponseModel responseModel = new UpdateShopInfoResponseModel(MessageCode.OK, "");
                _shopService.UpdateShopInfo(request.Shop);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdateShopInfoResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
