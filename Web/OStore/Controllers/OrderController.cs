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
        [HttpGet]
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

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model);
        }

        [HttpGet]
        public ActionResult PickPackOrder()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model);
        }

        [HttpGet]
        public ActionResult PayCODList()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model);
        }

        public ActionResult OrderContactDetail(string id)
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model.Where(m => m.OrderId == id).FirstOrDefault());
        }

        [HttpGet]
        public ActionResult PrepayList()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = "" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = "" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH003") });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH004") });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "3", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH005") });

            return View(model);
        }

        [HttpGet]
        public ActionResult UploadSlip(string id)
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = "" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = ""});
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH003") });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH004") });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "3", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH005") });

            return View(model.Where(m => m.OrderId == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult UploadSlip(OrderInfoViewModel model)
        {
            List<OrderInfoViewModel> models = new List<OrderInfoViewModel>();
            models.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = "" });
            models.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = "" });
            models.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH003") });
            models.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH004") });
            models.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "3", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", SlipFile = string.Format("{0}/orders/{1}/1.jpg", SessionProvider.Instance.CurrentShop.Id, "OSH005") });

            return View("PrepayList", models);
        }

        [HttpPost]
        public ActionResult SaveStransferSlip()
        {
            bool isSavedSuccessfully = true;
            try
            {
                //foreach (string fileName in Request.Files)
                //{
                //    HttpPostedFileBase file = Request.Files[fileName];
                //    if (file != null && file.ContentLength > 0)
                //    {
                //        ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "1");
                //    }
                //}
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


        #region Pick
        [HttpGet]
        public ActionResult PickOrder()
        {
            List<PickPackOrderInfoViewModel> model = new List<PickPackOrderInfoViewModel>();

            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model);
        } 
        #endregion

        #region Pack
        [HttpGet]
        public ActionResult PackOrder()
        {
            List<PickPackOrderInfoViewModel> model = new List<PickPackOrderInfoViewModel>();

            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });
            model.Add(new PickPackOrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "Approve", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark" });

            return View(model);
        }

        [HttpPost]
        public ActionResult PackOrder(List<PickPackOrderInfoViewModel> models)
        {

            return View("ConfirmPack", new List<PickPackOrderInfoViewModel>());
        }

        [HttpGet]
        public ActionResult ConfirmPack()
        {
            List<ConfirmPackOrderViewModel> models = new List<ConfirmPackOrderViewModel>();
            models.Add(new ConfirmPackOrderViewModel() { OrderId = "OST0001", CustomerName = "Somkid Junyaran", TrackingNumber = "OST0001" });
            models.Add(new ConfirmPackOrderViewModel() { OrderId = "OST0002", CustomerName = "Hoya Deejungbuiy", TrackingNumber = "OST0002" });
            models.Add(new ConfirmPackOrderViewModel() { OrderId = "OST0003", CustomerName = "Racha Rakthai", TrackingNumber = "" });
            models.Add(new ConfirmPackOrderViewModel() { OrderId = "OST0004", CustomerName = "Channel One", TrackingNumber = "" });
            models.Add(new ConfirmPackOrderViewModel() { OrderId = "OST0005", CustomerName = "Samart Jong Jor hor", TrackingNumber = "OST0005" });

            return View(models);
        }
        #endregion

        #region Ship
        [HttpGet]
        public ActionResult ShipOrder()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Alpha" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Alhpa" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Thaipost" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Thaipost" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Alpha" });

            return View(model);
        }
        #endregion
    }
}