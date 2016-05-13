using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class UpdateProductRequestModel
    {
        public UpdateProductRequestModel() { Product = new OStore.Model.Base.ProductModel(); }
        public OStore.Model.Base.ProductModel Product { get; set; }
    }
    public class UpdateProductResponseModel : ResponseModelBase
    {
        public UpdateProductResponseModel(MessageCode code, string message) : base(code, message) { }
    }
}