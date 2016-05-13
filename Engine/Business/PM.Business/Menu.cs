using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Menu : PM.Business.Base.MenuBase
    {
        public Menu(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.MenuModel> GetMenues()
        {
            try
            {
                List<OStore.Model.Base.MenuModel> result = new List<OStore.Model.Base.MenuModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    var q = (from ug in context.AuthorizeUserMapGroups
                             join gr in context.AuthorizeGroupMapRoles on ug.AuthorizeGroupId equals gr.AuthorizeGroupId
                             join rm in context.AuthorizeRoleMapMenus on gr.AuthorizeGroupId equals rm.AuthorizeRoleId
                             join m in context.Menus on rm.MenuId equals m.Id
                             where ug.AuthorizeUserId == CurrentUserId && ug.IsActive && gr.IsActive && rm.IsActive && m.IsActive
                             select m).Distinct();

                    List<OStore.Data.EF.Menu> menues = q.ToList().OrderBy(m => m.Seq).ToList();

                    result = Mapper.Map(menues, result);
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
