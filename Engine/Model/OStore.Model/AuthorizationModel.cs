using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Model
{
    [Serializable]
    public class AuthorizationModel
    {
        public AuthorizationModel() { UserInfo = new AuthorizeUserModel(); Roles = new List<AuthorizeRoleModel>(); }
        public AuthorizeUserModel UserInfo { get; set; }
        public List<AuthorizeRoleModel> Roles { get; set; }
    }
}
