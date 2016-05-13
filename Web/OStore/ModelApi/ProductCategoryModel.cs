using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class ProductCategoryRequestModel
    {

    }

    public class ProductCategoryResponseModel : ResponseModelBase
    {
        public ProductCategoryResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            Categories = new List<ProductCategoryViewModel>();
        }

        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}