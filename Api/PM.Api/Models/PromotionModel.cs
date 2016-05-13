using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class GetPromotionRequestModel
    {

    }

    public class GetPromotionResponseModel : ResponseModelBase
    {
        public GetPromotionResponseModel(MessageCode code, string message) : base(code, message) { Promotions = new List<OStore.Model.Base.PromotionModel>(); }
        public List<OStore.Model.Base.PromotionModel> Promotions { get; set; }
    }

    public class UpdatePromotionRequestModel
    {
        public UpdatePromotionRequestModel() { Promotion = new OStore.Model.Base.PromotionModel(); }
        public OStore.Model.Base.PromotionModel Promotion { get; set; }
    }

    public class UpdatePromotionResponseModel : ResponseModelBase
    {
        public UpdatePromotionResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}