using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Delivery
{
    public class DeliveryController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.DeliveryService _deliveryService;

        public DeliveryController() { _deliveryService = new Service.DeliveryService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetDeliveryChannels")]
        public GetDeliveryChannelResponseModel GetDeliveryChannels(GetDeliveryChannelRequestModel requestModel)
        {
            try
            {
                GetDeliveryChannelResponseModel responseModel = new GetDeliveryChannelResponseModel(MessageCode.OK, "");
                responseModel.DeliveryChannels = _deliveryService.GetDeliveryChannels();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetDeliveryChannelResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _deliveryService != null)
            {
                _deliveryService.Dispose();
                _deliveryService = null;
            }

            base.Dispose(disposing);
        }
    }
}
