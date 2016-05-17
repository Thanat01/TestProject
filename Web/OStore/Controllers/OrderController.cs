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
        public ActionResult ShipOrder()
        {
            List<OrderInfoViewModel> model = new List<OrderInfoViewModel>();

            model.Add(new OrderInfoViewModel() { OrderId = "OSH001", OrderDate = DateTime.Now, TimeLaps = "10 mins.", CustomerName = "Somkid Junyaran", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver="Alpha" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH002", OrderDate = DateTime.Now, TimeLaps = "15 mins.", CustomerName = "Hoya Deejungbuiy", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "1", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Alhpa" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH003", OrderDate = DateTime.Now, TimeLaps = "20 mins.", CustomerName = "Racha Rakthai", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Thaipost" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH004", OrderDate = DateTime.Now, TimeLaps = "25 mins.", CustomerName = "Channel One", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Thaipost" });
            model.Add(new OrderInfoViewModel() { OrderId = "OSH005", OrderDate = DateTime.Now, TimeLaps = "30 mins.", CustomerName = "Samart Jong Jor hor", Mobile = "08566505532", Line = "LineId", Price = 1000, StatusId = "2", Reason = "Reason", StoreStaff = "Koi", ItemLine = "1234567890", ItemCode = "1234567890", ItemDescription = "Description", Remark = "Remark", Deliver = "Alpha" });

            return View(model);
        }


    }
}