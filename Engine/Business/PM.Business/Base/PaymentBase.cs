using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class PaymentBase : Library.Business.Base.BusinessBase
    {
        public PaymentBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.PaymentChannel, OStore.Model.Base.PaymentChannelModel>();
            Mapper.CreateMap<OStore.Model.Base.PaymentChannelModel, OStore.Data.EF.PaymentChannel>();

            Mapper.CreateMap<OStore.Data.EF.ShopPaymentAccount, OStore.Model.Base.ShopPaymentAccountModel>();
            Mapper.CreateMap<OStore.Model.Base.ShopPaymentAccountModel, OStore.Data.EF.ShopPaymentAccount>();
        }
    }
}
