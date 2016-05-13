using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OM.Api.Models
{
    public class GetSaleChannelRequestModel
    {

    }
    public class GetSaleChannelResponseModel : ResponseModelBase
    {
        public GetSaleChannelResponseModel(MessageCode code, string message) : base(code, message) { SaleChannels = new List<OStore.Model.Base.SaleChannelModel>(); }

        public List<OStore.Model.Base.SaleChannelModel> SaleChannels { get; set; }
    }
}