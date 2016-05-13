using AutoMapper;
using OStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Business
{
    public class Authorization : AT.Business.Base.AuthorizationBase
    {
        public Authorization(int shopId)
            : base(shopId,0)
        {

        }

        public AuthorizationModel InternalSingIn(string userName, string password)
        {
            try
            {
                AuthorizationModel result = new AuthorizationModel();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    OStore.Data.EF.AuthorizeUser user = context.AuthorizeUsers.Where(u => u.Username == userName && u.Password == password && u.IsActive && u.ShopId == CurrentShopId).FirstOrDefault();
                    if (user != null)
                    {
                        OStore.Model.Base.AuthorizeUserModel userModel = new OStore.Model.Base.AuthorizeUserModel();
                        userModel = Mapper.Map(user, userModel);
                        result.UserInfo = userModel;

                        result.Roles = Mapper.Map(GetUserRoles(context, user.Id), result.Roles);
                    }
                    else
                    {
                        throw new Exception("Invalid user or bad password.");
                    }
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AuthorizationModel ExternalSingIn(string externalSystem, string externalUserId)
        {
            try
            {
                AuthorizationModel result = new AuthorizationModel();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {

                    OStore.Data.EF.AuthorizeUser user = (from ex in context.ExternalSystems
                                                         join eu in context.AuthorizeExternalSystemUsers on ex.Id equals eu.ExternalSystemId
                                                         join au in context.AuthorizeUsers on eu.AuthorizeUserId equals au.Id
                                                         where ex.SystemName == externalSystem && ex.IsActive && eu.ExternalUserId == externalUserId && eu.IsActive && au.ShopId == CurrentShopId && au.IsActive
                                                         select au).FirstOrDefault();
                    if (user != null)
                    {
                        OStore.Model.Base.AuthorizeUserModel userModel = new OStore.Model.Base.AuthorizeUserModel();
                        userModel = Mapper.Map(user, userModel);
                        result.UserInfo = userModel;

                        result.Roles = Mapper.Map(GetUserRoles(context, user.Id), result.Roles);
                    }
                    else
                    {
                        throw new Exception("Invalid user or bad password.");
                    }
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<OStore.Model.Base.AuthorizeRoleModel> GetUserRoles(OStore.Data.EF.OStoreDBEntities context, int userId)
        {
            try
            {
                List<OStore.Model.Base.AuthorizeRoleModel> result = new List<OStore.Model.Base.AuthorizeRoleModel>();

                List<OStore.Data.EF.AuthorizeRole> roles = (from ug in context.AuthorizeUserMapGroups
                                                            join gr in context.AuthorizeGroupMapRoles on ug.AuthorizeGroupId equals gr.AuthorizeGroupId
                                                            join ar in context.AuthorizeRoles on gr.AuthorizeRoleId equals ar.Id
                                                            where ug.AuthorizeUserId == userId && ar.ShopId == CurrentShopId && ug.IsActive && gr.IsActive && ar.IsActive
                                                            select ar).Distinct().ToList();

                roles.ForEach(r =>
                {
                    OStore.Model.Base.AuthorizeRoleModel roleModel = new OStore.Model.Base.AuthorizeRoleModel();
                    roleModel = Mapper.Map(r, roleModel);
                    result.Add(roleModel);
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
