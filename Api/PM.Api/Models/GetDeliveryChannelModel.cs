using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{

    [Serializable]
    public class GetDeliveryChannelRequestModel
    {

    }

    [Serializable]
    public class GetDeliveryChannelResponseModel : ResponseModelBase
    {
        public GetDeliveryChannelResponseModel(MessageCode code, string message) : base(code, message) { DeliveryChannels = new List<OStore.Model.Base.DeliveryChannelModel>(); }

        public List<OStore.Model.Base.DeliveryChannelModel> DeliveryChannels { get; set; }
    }
}