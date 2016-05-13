using Library.Api.Model;
using OStore.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class GetCustomersRequestModel
    {
        public GetCustomersRequestModel() { }
    }
    public class GetCustomersResponseModel : ResponseModelBase
    {
        public GetCustomersResponseModel(MessageCode code, string message) : base(code, message) { Customers = new List<CustomerModel>(); }
        public List<CustomerModel> Customers { get; set; }
    }
}