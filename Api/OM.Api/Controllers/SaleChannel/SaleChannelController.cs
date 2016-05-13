using Library.Api.Model;
using OM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OM.Api.Controllers.SaleChannel
{
    public class SaleChannelController : Library.Api.Controller.Base.ApiControllerBase
    {
        OM.Service.SaleChannelService _saleChannelService;

        public SaleChannelController() { _saleChannelService = new OM.Service.SaleChannelService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetSaleChennels")]
        public GetSaleChannelResponseModel GetSaleChennels(GetSaleChannelRequestModel requestModel)
        {
            try
            {
                GetSaleChannelResponseModel responseModel = new GetSaleChannelResponseModel(MessageCode.OK, "");
                responseModel.SaleChannels = _saleChannelService.GetSaleChannels();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetSaleChannelResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
