using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdateProductCategoryResquestModel
    {
        public UpdateProductCategoryResquestModel() { Categories = new List<ProductCategoryViewModel>(); }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
    public class UpdateProductCategoryResponseModel : ResponseModelBase
    {
        public UpdateProductCategoryResponseModel(MessageCode code, string message) : base(code, message) { }

    }
}