using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OM.Api.Models
{
    public class GetOrdersRequestModel
    {

    }
    public class GetOrdersResponseModel : ResponseModelBase
    {
        public GetOrdersResponseModel(MessageCode code, string message) : base(code, message) { Orders = new List<OStore.Model.Base.PersonOrderModel>(); }

        public List<OStore.Model.Base.PersonOrderModel> Orders { get; set; }
    }
}