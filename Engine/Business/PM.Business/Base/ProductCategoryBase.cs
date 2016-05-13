using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PM.Business.Base
{
    public class ProductCategoryBase : Library.Business.Base.BusinessBase
    {
        public ProductCategoryBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.ProductCategory, OStore.Model.Base.ProductCategoryModel>();
            Mapper.CreateMap<OStore.Model.Base.ProductCategoryModel, OStore.Data.EF.ProductCategory>();
        }
    }
}
