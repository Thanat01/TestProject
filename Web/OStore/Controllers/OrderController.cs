using OStore.Models.Orders;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Libs.Extensions;

namespace OStore.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            SearchConditionViewModel model = new SearchConditionViewModel();
            model.Provinces = CacheProvider.Instance.Provinces;
            model.SaleChannels = SessionProvider.Instance.SaleChannels.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select Sale channel", false);


            return View(model);
        }


        [HttpGet]
        public ActionResult PayOrder()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            return View(model);
        }

        [HttpGet]
        public ActionResult PickPackOrder()
        {


            return View();
        }

        [HttpGet]
        public ActionResult ShipOrder()
        {


            return View();
        }


    }
}