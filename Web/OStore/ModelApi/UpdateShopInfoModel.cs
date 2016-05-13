using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdateShopInfoRequestModel
    {
        public UpdateShopInfoRequestModel() { Shop = new ShopModel(); }

        public ShopModel Shop { get; set; }
    }

    public class UpdateShopInfoResponseModel : ResponseModelBase
    {
        public UpdateShopInfoResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}