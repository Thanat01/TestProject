using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business
{
    public class SaleChannel : OM.Business.Base.SaleChannelBase
    {
        public SaleChannel(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.SaleChannelModel> GetSaleChannels()
        {
            try
            {
                List<OStore.Model.Base.SaleChannelModel> result = new List<OStore.Model.Base.SaleChannelModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    List<OStore.Data.EF.SaleChannel> saleChannel = context.SaleChannels.Where(s => s.ShopId == CurrentShopId && s.IsActive).ToList();

                    result = Mapper.Map(saleChannel, result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
