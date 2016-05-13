using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Base
{
    public class SaleChannelBase : Library.Business.Base.BusinessBase
    {
        public SaleChannelBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.SaleChannel, OStore.Model.Base.SaleChannelModel>();
            Mapper.CreateMap<OStore.Model.Base.SaleChannelModel, OStore.Data.EF.SaleChannel>();
        }
    }
}
