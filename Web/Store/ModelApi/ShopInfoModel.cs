using Library.Api.Model;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.ModelApi
{
    public class ShopInfoRequestModel
    {
        public string DNS { get; set; }
    }

    public class ShopInfoResponseModel : ResponseModelBase
    {
        public ShopInfoResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            Shop = new ShopModel();
        }

        public ShopModel Shop { get; set; }
    }
}