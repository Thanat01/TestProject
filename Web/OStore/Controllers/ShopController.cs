using OStore.Models;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View(SessionProvider.Instance.CurrentShop);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopModel shop)
        {
            string userId = User.Identity.Name;
            ATApi.Instance.UpdateShopInfo(new ModelApi.UpdateShopInfoRequestModel() { Shop = shop });

            return View("Index", SessionProvider.Instance.CurrentShop);
        }

        public ActionResult Edit()
        {
            return View(SessionProvider.Instance.CurrentShop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ShopModel shop)
        {
            ATApi.Instance.UpdateShopInfo(new ModelApi.UpdateShopInfoRequestModel() { Shop = shop });

            return View("Index", SessionProvider.Instance.CurrentShop);
        }

        [HttpPost]
        public ActionResult SaveLogo()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveLogo(file);
                    }
                }
            }
            catch
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
                return Json(new { Message = "Secondary" });
            else
                return Json(new { Message = "Error in saving file" });
        }

    }
}