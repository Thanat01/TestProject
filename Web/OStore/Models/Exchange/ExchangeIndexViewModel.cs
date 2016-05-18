using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.Exchange
{
    [Serializable]
    public class ExchangeIndexViewModel
    {
        public List<ExchangeRecord> ExchangePendingRecords { get; set; }
    }

    [Serializable]
    public class ExchangeRecord
    {
        public string ExchangeId { get; set; }
        public string OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public string ReceiverName { get; set; }
        public string Contact { get; set; }
        public string LINE { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
    }
}