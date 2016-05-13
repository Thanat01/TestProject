using OStore.ModelApi;
using OStore.Models;
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
    }
}