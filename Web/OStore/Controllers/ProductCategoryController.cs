using OStore.Models;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class ProductCategoryController : Controller
    {
        [HttpGet, ActionName("List")]
        public ActionResult List()
        {
            return View(SessionProvider.Instance.ProductCategories);
        }

        [HttpGet, ActionName("GetAllCategories")]
        public JsonResult GetAllCategories()
        {
            return Json(SessionProvider.Instance.ProductCategories, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create(int? parentId)
        {
            Session["CategoryId"] = string.Format("New_{0}", Guid.NewGuid().ToString());
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductCategoryViewModel category)
        {
            PMApi.Instance.UpdateProductCategory(new ModelApi.UpdateProductCategoryResquestModel() { Categories = new List<ProductCategoryViewModel> { category } });
            ImageProvider.Instance.ReCategoryPathName(Session["CategoryId"].ToString(), category.Name);

            return View(SessionProvider.Instance.ProductCategories);
        }

        [HttpPost]
        public ActionResult SavePrimaryImageURL()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "1");
                    }
                }
            }
            catch
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
                return Json(new { Message = "Primary" });
            else
                return Json(new { Message = "Error in saving file" });
        }

        [HttpPost]
        public ActionResult SaveSecondaryImageURL()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "2");
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