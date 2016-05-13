using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class GetShopInfoRequestModel
    {
        public string DNS { get; set; }
    }

    public class GetShopInfoResponseModel : ResponseModelBase
    {
        public GetShopInfoResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            Shop = new ShopModel();
        }

        public ShopModel Shop { get; set; }
    }
}