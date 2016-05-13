using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdatePromotionRequestModel
    {
        public UpdatePromotionRequestModel() { Promotion = new PromotionViewModel(); }

        public PromotionViewModel Promotion { get; set; }
    }

    public class UpdatePromotionResponseModel : ResponseModelBase
    {
        public UpdatePromotionResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}