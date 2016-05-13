using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Promotion: PM.Business.Base.PromotionBase
    {
        public Promotion(int shopId, int userId) : base(shopId, userId) { }

        public void UpdatePromotion(OStore.Model.Base.PromotionModel model)
        {
            try
            {
                OStore.Data.EF.Promotion promotion = new OStore.Data.EF.Promotion();
                promotion = Mapper.Map(model, promotion);

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    if (promotion.Id <= 0)
                        context.DBEntry(promotion, System.Data.Entity.EntityState.Added);
                    else
                        context.DBEntry(promotion, System.Data.Entity.EntityState.Modified);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<OStore.Model.Base.PromotionModel> GetPromotions()
        {
            try
            {
                List<OStore.Model.Base.PromotionModel> result = new List<OStore.Model.Base.PromotionModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    List<OStore.Data.EF.Promotion> promotions = context.Promotions.Where(p => p.ShopId == CurrentShopId && p.IsActive == true).ToList(); 

                    result = Mapper.Map(promotions, result);
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
