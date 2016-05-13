using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class DeliveryBase: Library.Business.Base.BusinessBase
    {
        public DeliveryBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.DeliveryChannel, OStore.Model.Base.DeliveryChannelModel>();
            Mapper.CreateMap<OStore.Model.Base.DeliveryChannelModel, OStore.Data.EF.DeliveryChannel>();

        }
    }
}
