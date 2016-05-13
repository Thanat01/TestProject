using OStore.Domain;
using OStore.Models;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Index()
        {
            var data = new Data();
            return PartialView("_Navbar", data.NavbarItems(User.Identity.Name != "" ? SessionProvider.Instance.Menues : new List<MenuItemModel>()).ToList());
        }
    }
}