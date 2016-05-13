using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AT.Api.Models
{
    public class UserInfoResponseModel: ResponseModelBase
    {
        public UserInfoResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            UserInfo = new OStore.Model.Base.AuthorizeUserModel();
            Roles = new List<OStore.Model.Base.AuthorizeRoleModel>();
        }

        public OStore.Model.Base.AuthorizeUserModel UserInfo { get; set; }
        public List<OStore.Model.Base.AuthorizeRoleModel> Roles { get; set; }
    }
}