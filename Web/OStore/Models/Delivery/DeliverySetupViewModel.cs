using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OStore.Libs.Extensions;
using OStore.Providers;

namespace OStore.Models.Delivery
{
    [Serializable]
    public class DeliverySetupViewModel
    {
        public int Delivery1_Cost { get; set; }
        public int Delivery1_Days { get; set; }
        private List<CheckBox> chkDelivery1Options;
        public List<CheckBox> ChkDelivery1Options
        {
            get
            {
                if (chkDelivery1Options == null)
                {
                    chkDelivery1Options = CacheProvider.Instance.Delivery1OptionsCheckbox;
                }
                return chkDelivery1Options;
            }
            set
            {
                chkDelivery1Options = value;
            }
        }
        public bool Delivery1_Enabled { get; set; }

        public int Delivery2_Cost { get; set; }
        public int Delivery2_Days { get; set; }
        private List<CheckBox> chkDelivery2Options;
        public List<CheckBox> ChkDelivery2Options
        {
            get
            {
                if (chkDelivery2Options == null)
                {
                    chkDelivery2Options = CacheProvider.Instance.Delivery2OptionsCheckbox;
                }
                return chkDelivery2Options;
            }
            set
            {
                chkDelivery2Options = value;
            }
        }
        public bool Delivery2_Enabled { get; set; }

        //public bool Delivery1_COD { get; set; }
        //public bool Delivery1_BankTransfer { get; set; }
        //public bool Delivery1_AppointmentTime { get; set; }

    }
}