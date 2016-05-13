using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Business.Base
{
    public class AuthorizationBase : Library.Business.Base.BusinessBase
    {
        public AuthorizationBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.AuthorizeUser, OStore.Model.Base.AuthorizeUserModel>();
            Mapper.CreateMap<OStore.Model.Base.AuthorizeUserModel, OStore.Data.EF.AuthorizeUser>();

            Mapper.CreateMap<OStore.Data.EF.AuthorizeRole, OStore.Model.Base.AuthorizeRoleModel>();
            Mapper.CreateMap<OStore.Model.Base.AuthorizeRoleModel, OStore.Data.EF.AuthorizeRole>();
        }
    }
}
