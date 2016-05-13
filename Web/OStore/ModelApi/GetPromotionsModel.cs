using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class GetPromotionsRequestModel
    {

    }

    public class GetPromotionsResponseModel: ResponseModelBase
    {
        public GetPromotionsResponseModel(MessageCode code, string message) : base(code, message) { Promotions = new List<PromotionViewModel>(); }

        public List<PromotionViewModel> Promotions { get; set; }
    }
}