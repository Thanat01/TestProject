using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business
{
    public class CustomerOrder : OM.Business.Base.CustomerOrderBase
    {
        public CustomerOrder(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.PersonOrderModel> GetOrders()
        {
            try
            {
                List<OStore.Model.Base.PersonOrderModel> result = new List<OStore.Model.Base.PersonOrderModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    List<OStore.Data.EF.PersonOrder> orders = context.PersonOrders.Where(o => o.ShopId == CurrentShopId).ToList();

                    result = Mapper.Map(orders, result);
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
