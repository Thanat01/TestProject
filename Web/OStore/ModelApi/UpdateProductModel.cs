using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    public class UpdateProductRequestModel
    {
        public UpdateProductRequestModel() { Product = new ProductViewModel(); }

        public ProductViewModel Product { get; set; }
    }

    public class UpdateProductResponseModel : ResponseModelBase
    {
        public UpdateProductResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}