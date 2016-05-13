using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class PromotionBase : Library.Business.Base.BusinessBase
    {
        public PromotionBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.Promotion, OStore.Model.Base.PromotionModel>();
            Mapper.CreateMap<OStore.Model.Base.PromotionModel, OStore.Data.EF.Promotion>();
        }
    }
}
