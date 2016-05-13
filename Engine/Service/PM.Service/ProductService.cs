using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class ProductService
    {
        private PM.Business.ProductCategory _productCategory;
        private PM.Business.Product _product;

        public ProductService(int shopId, int userId)
        {
            _productCategory = new Business.ProductCategory(shopId, userId);
            _product = new Business.Product(shopId, userId);
        }

        #region Product Category
        public List<ProductCategoryModel> GetAllProductCategory(int shopId)
        {
            try
            {
                return _productCategory.GetAllProductCategory(shopId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProductCategories(List<ProductCategoryModel> categories)
        {
            try
            {
                _productCategory.UpdateProductCategories(categories);
            }
            catch (Exception)
            {
                throw;
            }
        } 
        #endregion

        #region Product
        public List<ProductModel> GetProducts(int categoryId)
        {
            try
            {
                return _product.GetProducts(categoryId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void UpdateProducts(OStore.Model.Base.ProductModel product)
        {
            try
            {
                _product.UpdateProduct(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
