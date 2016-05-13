using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Base
{
    public class CustomerOrderBase : Library.Business.Base.BusinessBase
    {
        public CustomerOrderBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.PersonOrder, OStore.Model.Base.PersonOrderModel>();
            Mapper.CreateMap<OStore.Model.Base.PersonOrderModel, OStore.Data.EF.PersonOrder>();
        }
    }
}
