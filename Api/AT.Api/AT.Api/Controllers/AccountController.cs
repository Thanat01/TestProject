using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using AT.Api.Models;
using AT.Api.Providers;
using AT.Api.Results;

namespace AT.Api.Controllers
{

    public class AccountController : Library.Api.Controller.Base.ApiControllerBase
    {
        AT.Service.AuthorizationService _authorizationService;

        public AccountController() { _authorizationService = new Service.AuthorizationService(CurrentShopId); }

        [HttpPost]
        [ActionName("InternalSignIn")]
        public UserInfoResponseModel InternalSignIn(InternalSingInRequestModel request)
        {
            try
            {
                UserInfoResponseModel response = new UserInfoResponseModel(Library.Api.Model.MessageCode.OK, "");

                OStore.Model.AuthorizationModel model = _authorizationService.InternalSingIn(request.UserName, request.Password);
                response.UserInfo = model.UserInfo;
                response.Roles.AddRange(model.Roles);

                return response;
            }
            catch (Exception ex)
            {
                return new UserInfoResponseModel(Library.Api.Model.MessageCode.Fail, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("ExternalSignIn")]
        public UserInfoResponseModel ExternalSignIn(ExternalSingInRequestModel request)
        {
            try
            {
                UserInfoResponseModel response = new UserInfoResponseModel(Library.Api.Model.MessageCode.OK, "");

                OStore.Model.AuthorizationModel model = _authorizationService.ExternalSingIn(request.ExternalSystem, request.ExternalUserId);
                response.UserInfo = model.UserInfo;
                response.Roles.AddRange(model.Roles);

                return response;
            }
            catch (Exception ex)
            {
                return new UserInfoResponseModel(Library.Api.Model.MessageCode.Fail, ex.Message);
            }
        }
    }
}
