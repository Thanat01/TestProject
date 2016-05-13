using OStore.Models;
using OStore.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Models.SaleChannel;

namespace OStore.Controllers
{
    public class SaleChannelController : Controller
    {
        // GET: SaleChannel
        public ActionResult Index()
        {
            return View(SessionProvider.Instance.SaleChannels);
        }

        [HttpGet]
        public ActionResult ImportOrder()
        {
            ImportOrderViewModel model = new ImportOrderViewModel();
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0001", RefId = "LZD0001", OrderDate = DateTime.Now, OrderQuantity = 10, Revenue = 1000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0002", RefId = "LZD0002", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0003", RefId = "LZD0003", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            return PartialView("_ImportOrder", model);
        }

        [HttpPost]
        public ActionResult ImportOrderData()
        {
            ImportOrderViewModel model = new ImportOrderViewModel();

            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0001", RefId = "LZD0001", OrderDate = DateTime.Now, OrderQuantity = 10, Revenue = 1000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0002", RefId = "LZD0002", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0003", RefId = "LZD0003", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            
            return PartialView("_ImportOrder", model);
        }

        [HttpPost]
        public ActionResult ImportOrder(ImportOrderViewModel model)
        {
            return PartialView("_ImportOrder", model);
        }

        [HttpGet]
        public ActionResult CreateOrderManual()
        {
            try
            {
                OrderManualViewModel model = new OrderManualViewModel()
                {
                    OrderId = "O0516E4",
                    RegisterLink = "https://bill.ostore.com/th/b/ZPz6dmv",
                    OrderDate = DateTime.Now,
                    Status = "Order",
                    CustomerId=1,
                    Firstname="Chuchart",
                    Lastname="RakThai"
                };

                model.DeliveryChannels = CacheProvider.Instance.DeliveryChannels;

                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 1, Image = "", Name = "Product 1", SKU = "SKU1", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1});
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 2, Image = "", Name = "Product 2", SKU = "SKU2", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 3, Image = "", Name = "Product 3", SKU = "SKU3", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 4, Image = "", Name = "Product 4", SKU = "SKU4", Price = 100, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 5, Image = "", Name = "Product 5", SKU = "SKU5", Price = 500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });

                return PartialView("_OrderManual",model);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [HttpPost]
        public ActionResult CreateOrderManual(OrderManualViewModel model)
        {
            try
            {
                

                return PartialView("_OrderManual", model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}