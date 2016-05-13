using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class UpdatePaymentChannelsRequestModel
    {
        public UpdatePaymentChannelsRequestModel() { Channels = new List<OStore.Model.PaymentChannelInfoModel>(); }
        public List<OStore.Model.PaymentChannelInfoModel> Channels { get; set; }
    }
    public class UpdatePaymentChannelsResponseModel : ResponseModelBase
    {
        public UpdatePaymentChannelsResponseModel(MessageCode code, string message) : base(code, message) { }
        
    }
}