using Library.Api.Model;
using OStore.Models.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{

    [Serializable]
    public class GetDeliveryChannelRequestModel
    {

    }

    [Serializable]
    public class GetDeliveryChannelResponseModel : ResponseModelBase
    {
        public GetDeliveryChannelResponseModel(MessageCode code, string message) : base(code, message) { DeliveryChannels = new List<DeliveryChannelModel>(); }

        public List<DeliveryChannelModel> DeliveryChannels { get; set; }
    }
}