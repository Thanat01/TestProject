using OStore.Models;
using OStore.Models.Promotion;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class MarketingController : Controller
    {
        // GET: Marketing
        public ActionResult Index()
        {

            return View(SessionProvider.Instance.Customers);
        }

        public ActionResult CustomerList()
        {
            return PartialView("_CustomerList", SessionProvider.Instance.Customers);
        }

        public ActionResult ReportPromotionCode()
        {
            List<ReportPromotionViewModel> models = new List<ReportPromotionViewModel>();

            for (int i = 1; i <= 3; i++)
            {
                ReportPromotionViewModel model = new ReportPromotionViewModel() { PromotionCode = "TRY201600" + i.ToString() };

                for (int j = 1; j <= 3; j++)
                {
                    model.Orders.Add(new PromotionOrderViewModel() {No=j,  OrderId = "LZD00"+j.ToString(), CustomerName =string.Format( "Customer{0} {1}",i,j), OrderDate = DateTime.Now, Revenue = 1000, Status = "Complete" });
                }
                    models.Add(model);
            }


            return PartialView("_ReportPromotionCode", models);
        }

        public ActionResult CreateNewPromotion()
        {
            PromotionViewModel model = new PromotionViewModel();



            return PartialView("_CreatePromotion", model);
        }
    }
}