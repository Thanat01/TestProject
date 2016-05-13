using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Models.Delivery;

namespace OStore.Controllers
{
    public class DeliveryController : Controller
    {
        public ActionResult Setup()
        {
            Lazy<DeliverySetupViewModel> lazyModel = new Lazy<DeliverySetupViewModel>();
            var viewModel = lazyModel.Value;


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Setup(DeliverySetupViewModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception ex)
            {
                    
                throw ex;
            }
        }
    }
}