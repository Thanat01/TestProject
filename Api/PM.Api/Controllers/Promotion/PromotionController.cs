using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Product
{
    public class PromotionController: Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.PromotionService _promotionService;

        public PromotionController() { _promotionService = new Service.PromotionService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetPromotions")]
        public GetPromotionResponseModel GetPromotions(GetProductRequestModel requestModel)
        {
            try
            {
                GetPromotionResponseModel responseModel = new GetPromotionResponseModel(MessageCode.OK, "");
                responseModel.Promotions = _promotionService.GetPromotions();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetPromotionResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdatePromotion")]
        public UpdatePromotionResponseModel UpdatePromotion(UpdatePromotionRequestModel requestModel)
        {
            try
            {
                UpdatePromotionResponseModel responseModel = new UpdatePromotionResponseModel(MessageCode.OK, "");
                _promotionService.UpdatePromotion(requestModel.Promotion);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdatePromotionResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
