using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    [Serializable]
    public class GetAllCategoryResquestModel
    {

    }

    [Serializable]
    public class GetAllCategoryResponseModel : ResponseModelBase
    {
        public GetAllCategoryResponseModel(MessageCode code, string message) : base(code, message) { Categories = new List<OStore.Model.Base.ProductCategoryModel>(); }

        public List<OStore.Model.Base.ProductCategoryModel> Categories { get; set; }
    }
}