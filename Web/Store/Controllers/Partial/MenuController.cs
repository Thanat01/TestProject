using Store.Models;
using Store.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers.Partial
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            return View(User.Identity.Name != "" ? SessionProvider.Instance.Menues : new List<MenuItemModel>());
        }
    }
}