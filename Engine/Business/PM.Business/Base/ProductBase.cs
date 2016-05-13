using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class ProductBase : Library.Business.Base.BusinessBase
    {
        public ProductBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.Product, OStore.Model.Base.ProductModel>();
            Mapper.CreateMap<OStore.Model.Base.ProductModel, OStore.Data.EF.Product>();
        }
    }
}
