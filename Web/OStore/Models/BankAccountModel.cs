using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class BankAccountModel
    {
        public BankAccountModel()
        {
            Banks = new List<System.Web.Mvc.SelectListItem>();
        }

        public int BankId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Banks { get; set; }

        public string Branch { get; set; }

        public string Name { get; set; }

        public string AccountNo { get; set; }
    }
}