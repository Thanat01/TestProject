using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    [Serializable]
    public class GetMenuesRequestModel
    {

    }

    [Serializable]
    public class GetMenuesResponseModel : ResponseModelBase
    {
        public GetMenuesResponseModel(MessageCode code, string message) : base(code, message) { Menues = new List<OStore.Model.Base.MenuModel>(); }

        public List<OStore.Model.Base.MenuModel> Menues { get; set; }
    }
}