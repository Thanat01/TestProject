using Library.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Models;

namespace Store.ModelApi
{
    public class UserInfoResponseModel : ResponseModelBase
    {
        public UserInfoResponseModel(MessageCode code, string message)
            : base(code, message)
        {
            UserInfo = new UserInfoModel();
            Roles = new List<RoleModel>();
            Status = Microsoft.AspNet.Identity.Owin.SignInStatus.Failure;
        }

        public Microsoft.AspNet.Identity.Owin.SignInStatus Status { get; set; }
        public UserInfoModel UserInfo { get; set; }
        public List<RoleModel> Roles { get; set; }
    }
}