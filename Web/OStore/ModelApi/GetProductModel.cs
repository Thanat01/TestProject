using Library.Api.Model;
using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.ModelApi
{
    [Serializable]
    public class GetProductRequestModel
    {
        public int CategoryId { get; set; }
    }

    [Serializable]
    public class GetProductResponseModel : ResponseModelBase
    {
        public GetProductResponseModel(MessageCode code, string message) : base(code, message) { Products = new List<ProductViewModel>(); }

        public List<ProductViewModel> Products { get; set; }
    }
}