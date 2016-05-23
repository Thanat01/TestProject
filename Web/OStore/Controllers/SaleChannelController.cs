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
        public ActionResult FirstIndex()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ImportOrder()
        {
            ImportOrderViewModel model = new ImportOrderViewModel();
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0001", RefId = "LZD0001", OrderDate = DateTime.Now, OrderQuantity = 10, Revenue = 1000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0002", RefId = "LZD0002", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0003", RefId = "LZD0003", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            return View(model);
        }

        [HttpPost]
        public ActionResult ImportOrder(ImportOrderViewModel model)
        {
            model = new ImportOrderViewModel();

            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0001", RefId = "LZD0001", OrderDate = DateTime.Now, OrderQuantity = 10, Revenue = 1000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0002", RefId = "LZD0002", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });
            model.Orders.Add(new ImportOrderModel() { OrderId = "OST0003", RefId = "LZD0003", OrderDate = DateTime.Now, OrderQuantity = 20, Revenue = 2000, Status = "Delivery" });

            return View(model);
        }


        [HttpGet]
        public ActionResult CreateOrderManual(string id)
        {
            try
            {
                OrderManualViewModel model = new OrderManualViewModel()
                {
                    OrderId = id != "" ? id : "OST0516E4",
                    RegisterLink = "http://cassy-o.webflow.io/request-details",
                    OrderDate = DateTime.Now,
                    Status = "Order",
                    CustomerId = 1,
                    Firstname = "Chuchart",
                    Lastname = "RakThai"
                };

                model.DeliveryChannels = CacheProvider.Instance.DeliveryChannels;


                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 1, Image = "1/products/11.jpg", Name = "Product 1", SKU = "SKU1", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 2, Image = "1/products/12.jpg", Name = "Product 2", SKU = "SKU2", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 3, Image = "1/products/13.jpg", Name = "Product 3", SKU = "SKU3", Price = 1500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 4, Image = "1/products/14.jpg", Name = "Product 4", SKU = "SKU4", Price = 100, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });
                model.Products.Add(new Models.Product.OrderProductViewModel() { Id = 5, Image = "1/products/15.jpg", Name = "Product 5", SKU = "SKU5", Price = 500, OrderQuantity = 1, StockQuantity = 10, ColorId = 1, SizeId = 1 });

                return View("CreateOrderManual", model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult OrderList()
        {
            try
            {
                List<OStore.Models.SaleChannel.OrderListViewModel> models = new List<OStore.Models.SaleChannel.OrderListViewModel>();

                models.Add(new OrderListViewModel() { OrderId = "OST0001", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "1", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0002", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "2", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0003", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "3", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0004", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "1", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0005", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "2", Email = "suchart@gmail.com", PaymentType = "COD" });



                return View(models);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult OrderList(List<OStore.Models.SaleChannel.OrderListViewModel> models)
        {
            try
            {
                models = new List<OStore.Models.SaleChannel.OrderListViewModel>();

                models.Add(new OrderListViewModel() { OrderId = "OST0001", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "1", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0002", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "2", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0003", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "3", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0004", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "1", Email = "suchart@gmail.com", PaymentType = "COD" });
                models.Add(new OrderListViewModel() { OrderId = "OST0005", OrderDate = DateTime.Now, CustomerId = 1, Firstname = "Somboon", Lastname = "Sornporn", Mobile = "0854327654", Address = "Bangkok", StatusId = "2", Email = "suchart@gmail.com", PaymentType = "COD" });



                return View(models);
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

        public ActionResult ShowCustomerList()
        {

            return PartialView("_CustomerList", SessionProvider.Instance.Customers);
        }
    }
}