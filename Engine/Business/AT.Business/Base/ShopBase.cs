using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Business.Base
{
    public class ShopBase : Library.Business.Base.BusinessBase
    {
        public ShopBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.Shop, OStore.Model.Base.ShopModel>();
            Mapper.CreateMap<OStore.Model.Base.ShopModel, OStore.Data.EF.Shop>();
        }
    }
}
