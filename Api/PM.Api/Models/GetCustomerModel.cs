using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class GetCustomersRequestModel
    {
        public GetCustomersRequestModel() { }
    }
    public class GetCustomersResponseModel : ResponseModelBase
    {
        public GetCustomersResponseModel(MessageCode code, string message) : base(code, message) { Customers = new List<OStore.Model.CustomerInfoModel>(); }
        public List<OStore.Model.CustomerInfoModel> Customers { get; set; }
    }
}