using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Base
{
    public class BusinessBase
    {
        protected int CurrentShopId;
        protected int CurrentUserId;
        public BusinessBase(int shopId, int userId)
        {
            CurrentShopId = shopId;
            CurrentUserId = userId;
        }
    }
}
