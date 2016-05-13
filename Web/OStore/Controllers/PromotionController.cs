using OStore.Models;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class PromotionController : Controller
    {
        [HttpGet, ActionName("List")]
        public ActionResult List()
        {
            return View(SessionProvider.Instance.Promotions);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PromotionViewModel promotion)
        {
            PMApi.Instance.UpdatePromotion(new ModelApi.UpdatePromotionRequestModel() { Promotion = promotion });

            return View("List",SessionProvider.Instance.Promotions);
        }

        [HttpGet, ActionName("GetAllPromotions")]
        public JsonResult GetAllPromotions()
        {
            return Json(SessionProvider.Instance.Promotions, JsonRequestBehavior.AllowGet);
        }
    }
}