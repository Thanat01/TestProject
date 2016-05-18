using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Models.Exchange;

namespace OStore.Controllers
{
    public class ExchangeController : Controller
    {
        // GET: Exchange
        public ActionResult Index()
        {
            ExchangeIndexViewModel viewModel = new ExchangeIndexViewModel
            {
                ExchangePendingRecords = new List<ExchangeRecord>
                {
                    new ExchangeRecord()
                    {
                        ExchangeId = "100"
                    },
                    new ExchangeRecord()
                    {
                        ExchangeId = "200"
                    }
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ExchangePick(string exchangeid, ExchangeIndexViewModel model)
        {
            try
            {

                return RedirectToAction("Index",new { });
            }
            catch (Exception)
            {
                    
                throw;
            }
        }
    }
}