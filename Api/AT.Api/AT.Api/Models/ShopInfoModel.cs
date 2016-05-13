using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AT.Api.Models
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
            Shop = new OStore.Model.ShopInfoModel();
        }

        public OStore.Model.ShopInfoModel Shop { get; set; }
    }

    public class UpdateShopInfoRequestModel
    {
        public UpdateShopInfoRequestModel() { Shop = new OStore.Model.ShopInfoModel(); }

        public OStore.Model.ShopInfoModel Shop { get; set; }
    }

    public class UpdateShopInfoResponseModel : ResponseModelBase
    {
        public UpdateShopInfoResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}