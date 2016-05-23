using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.Orders
{
    public class PickPackOrderInfoViewModel : OrderInfoViewModel
    {
        public PickPackOrderInfoViewModel()
        {
            OrderItems = new List<OrderItem>();

            OrderItems.Add(new OrderItem() { SKU = "DD002", Location = "R001/S002", QTY = 2, ProductImageURL = "11.jpg" });
            OrderItems.Add(new OrderItem() { SKU = "DD003", Location = "R001/S001", QTY = 3, ProductImageURL = "12.jpg" });
            OrderItems.Add(new OrderItem() { SKU = "DD004", Location = "R001/S003", QTY = 4, ProductImageURL = "13.jpg" });
        }

        public bool Choose { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public string SKU { get; set; }
        public string Location { get; set; }
        public int QTY { get; set; }
        public string ProductImageURL { get; set; }
    }
}