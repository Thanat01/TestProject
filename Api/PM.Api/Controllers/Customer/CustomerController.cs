using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Customer
{
    public class CustomerController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.CustomerService _customerService;

        public CustomerController() { _customerService = new Service.CustomerService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetCustomers")]
        public GetCustomersResponseModel GetCustomers(GetCustomersRequestModel requestModel)
        {
            try
            {
                GetCustomersResponseModel responseModel = new GetCustomersResponseModel(MessageCode.OK, "");
                responseModel.Customers = _customerService.GetCustomers();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetCustomersResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdateCustomers")]
        public UpdateCustomersResponseModel UpdateCustomers(UpdateCustomersRequestModel requestModel)
        {
            try
            {
                UpdateCustomersResponseModel responseModel = new UpdateCustomersResponseModel(MessageCode.OK, "");
                _customerService.UpdateCustomers(requestModel.Customers);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdateCustomersResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
