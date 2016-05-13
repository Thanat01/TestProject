using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.Api.Models
{
    public class GetStocksRequestModel
    {
        public GetStocksRequestModel() { }
    }
    public class GetStocksResponseModel : ResponseModelBase
    {
        public GetStocksResponseModel(MessageCode code, string message) : base(code, message) { Stocks = new List<OStore.Model.StockModel>(); }
        public List<OStore.Model.StockModel> Stocks { get; set; }
    }
}