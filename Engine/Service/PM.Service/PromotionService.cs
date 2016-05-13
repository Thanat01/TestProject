using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class PromotionService
    {
        private PM.Business.Promotion _promotion;

        public PromotionService(int shopId, int userId)
        {
            _promotion = new Business.Promotion(shopId, userId);
        }

        public List<OStore.Model.Base.PromotionModel> GetPromotions()
        {
            try
            {
                return _promotion.GetPromotions();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePromotion(OStore.Model.Base.PromotionModel promotionModel)
        {
            try
            {
                _promotion.UpdatePromotion(promotionModel);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
