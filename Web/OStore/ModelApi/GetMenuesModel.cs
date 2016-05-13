using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    [Serializable]
    public class GetMenuesRequestModel
    {

    }

    [Serializable]
    public class GetMenuesResponseModel : ResponseModelBase
    {
        public GetMenuesResponseModel(MessageCode code, string message) : base(code, message) { Menues = new List<MenuItemModel>(); }

        public List<MenuItemModel> Menues { get; set; }
    }
}