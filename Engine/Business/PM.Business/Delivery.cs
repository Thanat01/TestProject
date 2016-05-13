using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Delivery : PM.Business.Base.DeliveryBase
    {
        public Delivery(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.DeliveryChannelModel> GetDeliveryChannels()
        {
            try
            {
                List<OStore.Model.Base.DeliveryChannelModel> result = new List<OStore.Model.Base.DeliveryChannelModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = Mapper.Map(context.DeliveryChannels.Where(p => p.IsActive).ToList(), result);
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
