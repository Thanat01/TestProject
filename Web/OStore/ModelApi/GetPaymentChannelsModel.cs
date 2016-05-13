using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class GetPaymentChannelsRequestModel
    {
        public GetPaymentChannelsRequestModel() { }
    }
    public class GetPaymentChannelsResponseModel : ResponseModelBase
    {
        public GetPaymentChannelsResponseModel(MessageCode code, string message) : base(code, message) { Channels = new List<PaymentChannelModel>(); }
        public List<PaymentChannelModel> Channels { get; set; }
    }
}