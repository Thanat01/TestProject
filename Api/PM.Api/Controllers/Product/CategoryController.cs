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
    public class CategoryController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.ProductService _productService;

        public CategoryController() { _productService = new Service.ProductService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetAllCategory")]
        public GetAllCategoryResponseModel GetAllCategory(GetAllCategoryResquestModel requestModel)
        {
            try
            {
                GetAllCategoryResponseModel responseModel = new GetAllCategoryResponseModel(MessageCode.OK, "");
                responseModel.Categories = _productService.GetAllProductCategory(CurrentShopId);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetAllCategoryResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("UpdateCategory")]
        public UpdateCategoryResponseModel UpdateCategory(UpdateCategoryResquestModel requestModel)
        {
            try
            {
                UpdateCategoryResponseModel responseModel = new UpdateCategoryResponseModel(MessageCode.OK, "");
                _productService.UpdateProductCategories(requestModel.Categories);

                return responseModel;
            }
            catch (Exception ex)
            {
                return new UpdateCategoryResponseModel(MessageCode.Fail, ex.Message);
            }
        }
    }
}
