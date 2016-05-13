using Library.Api.Model;
using OStore.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdateCustomersRequestModel
    {
        public UpdateCustomersRequestModel() { Customers = new List<CustomerModel>(); }
        public List<CustomerModel> Customers { get; set; }
    }
    public class UpdateCustomersResponseModel : ResponseModelBase
    {
        public UpdateCustomersResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}