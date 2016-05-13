using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM.Api.Models
{
    public class GetProductRequestModel
    {
        public GetProductRequestModel() { }
        public int CategoryId { get; set; }
    }
    public class GetProductResponseModel : ResponseModelBase
    {
        public GetProductResponseModel(MessageCode code, string message) : base(code, message) { Products = new List<OStore.Model.Base.ProductModel>(); }
        public List<OStore.Model.Base.ProductModel> Products { get; set; }
    }
}