using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Payment
{
    public class PaymentController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.PaymentService _paymentService;

        public PaymentController() { _paymentService = new Service.PaymentService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetPaymentChannels")]
        public GetPaymentChannelsResponseModel GetPaymentChannels(GetPaymentChannelsRequestModel requestModel)
        {
            try
            {
                GetPaymentChannelsResponseModel responseModel = new GetPaymentChannelsResponseModel(MessageCode.OK, "");
                responseModel.Channels = _paymentService.GetPayments();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetPaymentChannelsResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdatePaymentChannels")]
        public UpdatePaymentChannelsResponseModel UpdatePaymentChannels(UpdatePaymentChannelsRequestModel requestModel)
        {
            try
            {
                UpdatePaymentChannelsResponseModel responseModel = new UpdatePaymentChannelsResponseModel(MessageCode.OK, "");
                _paymentService.UpdatePayments(requestModel.Channels);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdatePaymentChannelsResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
