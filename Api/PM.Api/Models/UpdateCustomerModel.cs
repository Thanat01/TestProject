using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class UpdateCustomersRequestModel
    {
        public UpdateCustomersRequestModel() { Customers = new List<OStore.Model.CustomerInfoModel>(); }
        public List<OStore.Model.CustomerInfoModel> Customers { get; set; }
    }
    public class UpdateCustomersResponseModel : ResponseModelBase
    {
        public UpdateCustomersResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}