﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models
{
    public class SaleChannelViewModel
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}