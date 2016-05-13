using Library.Api.Model;
using OM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OM.Api.Controllers.Order
{
    public class OrderController : Library.Api.Controller.Base.ApiControllerBase
    {
        OM.Service.OrderService _orderService;

        public OrderController() { _orderService = new OM.Service.OrderService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetOrders")]
        public GetOrdersResponseModel GetOrders(GetOrdersRequestModel requestModel)
        {
            try
            {
                GetOrdersResponseModel responseModel = new GetOrdersResponseModel(MessageCode.OK, "");
                responseModel.Orders = _orderService.GetOrders();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetOrdersResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
