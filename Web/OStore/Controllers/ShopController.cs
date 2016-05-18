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
            Lazy<ShopModel> lazyModel = new Lazy<ShopModel>();
            ShopModel viewModel = lazyModel.Value;
            //SessionProvider.Remove("ShopFAQs");
            //viewModel.FAQs = SessionProvider.Instance.ShopFAQs;
           

            //return View(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Edit(ShopModel shop, string command)
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                if (command == "Save")
                {
                    ATApi.Instance.UpdateShopInfo(new ModelApi.UpdateShopInfoRequestModel() { Shop = shop });
                }
            }
            return View("Index", SessionProvider.Instance.CurrentShop);
        }

        [HttpPost]
        public ActionResult SaveFAQ(ShopModel shop)
        {
            try
            {
                if(shop.ListOfFAQs==null)
                {
                    SessionProvider.Instance.ShopFAQs = new List<FAQ>();
                    SessionProvider.Instance.ShopFAQs.Add(shop.Faq);
                }
                else
                {
                    shop.ListOfFAQs.Add(shop.Faq);
                    SessionProvider.Instance.ShopFAQs = shop.ListOfFAQs;
                 
                }
              
                SessionProvider.Instance.ShopFAQs.RemoveAll(c => c== null);
                return RedirectToAction("Edit");
            }
            catch (Exception)
            {
                    
                throw;
            }
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