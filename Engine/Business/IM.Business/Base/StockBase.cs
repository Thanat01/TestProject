using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Business.Base
{
    public class StockBase : Library.Business.Base.BusinessBase
    {
        public StockBase(int shopId, int userId)
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
