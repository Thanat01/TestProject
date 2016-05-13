using Library.Api.Model;
using PM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM.Api.Controllers.Menu
{
    public class MenuController : Library.Api.Controller.Base.ApiControllerBase
    {
        PM.Service.MenuService _menuService;

        public MenuController() { _menuService = new Service.MenuService(CurrentShopId, CurrentUserId); }

        [HttpPost]
        [ActionName("GetMenues")]
        public GetMenuesResponseModel GetMenues(GetMenuesRequestModel requestModel)
        {
            try
            {
                GetMenuesResponseModel responseModel = new GetMenuesResponseModel(MessageCode.OK, "");
                responseModel.Menues = _menuService.GetMenus();

                return responseModel;
            }
            catch (Exception ex)
            {
                return new GetMenuesResponseModel(MessageCode.Fail, ex.Message);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _menuService != null)
            {
                _menuService.Dispose();
                _menuService = null;
            }

            base.Dispose(disposing);
        }
    }
}
