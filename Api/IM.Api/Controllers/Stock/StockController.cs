using IM.Api.Models;
using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IM.Api.Controllers.Stock
{
    public class StockController: Library.Api.Controller.Base.ApiControllerBase
    {
        IM.Service.StockService _stockService;

        public StockController() { _stockService = new IM.Service.StockService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetStocks")]
        public GetStocksResponseModel GetStocks(GetStocksRequestModel requestModel)
        {
            try
            {
                GetStocksResponseModel responseModel = new GetStocksResponseModel(MessageCode.OK, "");
                responseModel.Stocks = _stockService.GetStocks(null);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetStocksResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
