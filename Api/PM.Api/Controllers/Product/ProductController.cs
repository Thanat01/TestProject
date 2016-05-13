using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Product
{
    public class ProductController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.ProductService _productService;

        public ProductController() { _productService = new Service.ProductService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetProducts")]
        public GetProductResponseModel GetProducts(GetProductRequestModel requestModel)
        {
            try
            {
                GetProductResponseModel responseModel = new GetProductResponseModel(MessageCode.OK, "");
                responseModel.Products = _productService.GetProducts(requestModel.CategoryId);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetProductResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdateProduct")]
        public UpdateProductResponseModel UpdateProduct(UpdateProductRequestModel requestModel)
        {
            try
            {
                UpdateProductResponseModel responseModel = new UpdateProductResponseModel(MessageCode.OK, "");
                _productService.UpdateProducts(requestModel.Product);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdateProductResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
