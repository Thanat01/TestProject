using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
        public class GetPaymentChannelsRequestModel
        {
            public GetPaymentChannelsRequestModel() { }
        }
        public class GetPaymentChannelsResponseModel : ResponseModelBase
        {
            public GetPaymentChannelsResponseModel(MessageCode code, string message) : base(code, message) { Channels = new List<OStore.Model.PaymentChannelInfoModel>(); }
            public List<OStore.Model.PaymentChannelInfoModel> Channels { get; set; }
        }
}