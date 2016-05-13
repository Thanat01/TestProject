using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class GetSaleChannelRequestModel
    {

    }

    public class GetSaleChannelResponseModel : ResponseModelBase
    {
        public GetSaleChannelResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            SaleChannels=new List<SaleChannelViewModel>();
        }

        public List<SaleChannelViewModel> SaleChannels { get; set; }
    }
}