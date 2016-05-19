using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Models.ProductImport
{
    public class ImportImageViewModel
    {
        public ImportImageViewModel()
        {
            Images = new List<string>();
        }

        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsChecked { get; set; }
        public bool IsActive { get; set; }
        public List<string> Images { get; set; }
    }
}