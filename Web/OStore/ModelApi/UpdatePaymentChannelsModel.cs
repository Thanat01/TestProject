using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdatePaymentChannelsRequestModel
    {
        public UpdatePaymentChannelsRequestModel() { Channels = new List<PaymentChannelModel>(); }
        public List<PaymentChannelModel> Channels { get; set; }
    }
    public class UpdatePaymentChannelsResponseModel : ResponseModelBase
    {
        public UpdatePaymentChannelsResponseModel(MessageCode code, string message) : base(code, message) { }

    }
}