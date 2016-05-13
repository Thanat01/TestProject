using OStore.Models.Customer;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            return View(SessionProvider.Instance.Customers);
        }

        public ActionResult Create()
        {
            Lazy<CustomerModel> customer = new Lazy<CustomerModel>();
            var viewModel = customer.Value;
            try
            {
                return View(viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Create(CustomerModel customer)
        {
            PMApi.Instance.UpdateCustomers(new ModelApi.UpdateCustomersRequestModel() { Customers = new List<CustomerModel> { customer } });

            return View("List", SessionProvider.Instance.Customers);
        }

        public ActionResult Edit(int Id)
        {
            CustomerModel customer = new CustomerModel();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel customer)
        {
            PMApi.Instance.UpdateCustomers(new ModelApi.UpdateCustomersRequestModel() { Customers = new List<CustomerModel> { customer } });

            return View("List", SessionProvider.Instance.Customers);
        }

        [HttpGet, ActionName("GetAllCustomers")]
        public JsonResult GetAllCustomers()
        {
            return Json(SessionProvider.Instance.Customers, JsonRequestBehavior.AllowGet);
        }


        public ActionResult New()
        {
            Lazy<CustomerModel> customer = new Lazy<CustomerModel>();
            var viewModel = customer.Value;
            try
            {
                return View("Create",viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Create", viewModel);
            }

        }

        [HttpPost]
        public ActionResult New(CustomerModel model, string command)
        {
            Lazy<CustomerModel> customer = new Lazy<CustomerModel>();
            var viewModel = customer.Value;
            try
            {
              
                return View("Create",viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}