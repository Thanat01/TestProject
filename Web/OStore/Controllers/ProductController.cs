using OStore.ModelApi;
using OStore.Models;
using OStore.Models.Product;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet, ActionName("Index")]
        public ActionResult Index()
        {
            Session["ProductId"] = string.Format("New_{0}", Guid.NewGuid().ToString());
            return View();
        }

        [HttpGet, ActionName("List")]
        public ActionResult List(int? categoryId)
        {
            return View(SessionProvider.Instance.GetProduct(categoryId??0));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel product)
        {
            PMApi.Instance.UpdateProduct(new UpdateProductRequestModel() { Product = product });

            return View(SessionProvider.Instance.GetProduct(0));
        }

        [HttpPost]
        public ActionResult SaveProductImage()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveProduct(file, Session["ProductId"].ToString(), "");
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