using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class UpdateCategoryResquestModel
    {
        public UpdateCategoryResquestModel() { Categories = new List<OStore.Model.Base.ProductCategoryModel>(); }
        public List<OStore.Model.Base.ProductCategoryModel> Categories { get; set; }
    }
    public class UpdateCategoryResponseModel : ResponseModelBase
    {
        public UpdateCategoryResponseModel(MessageCode code, string message) : base(code, message) { }

    }
}