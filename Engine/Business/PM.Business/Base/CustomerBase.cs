using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class CustomerBase : Library.Business.Base.BusinessBase
    {
        public CustomerBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.Menu, OStore.Model.Base.MenuModel>();
            Mapper.CreateMap<OStore.Model.Base.MenuModel, OStore.Data.EF.Menu>();
        }
    }
}
