using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using OStore.Providers;

namespace OStore.Models
{
    [Serializable]
    public class ProductCategoryViewModel
    {
        //public int Id { get; set; }
        //public Nullable<int> ShopId { get; set; }
        //public Nullable<int> ParentId { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string PrimaryImageURL { get; set; }
        //public string SecondaryImageURL { get; set; }
        //public Nullable<int> PrimaryBoxSeq { get; set; }
        //public Nullable<int> SecondaryBoxSeq { get; set; }
        //public Nullable<int> Seq { get; set; }
        //public Nullable<bool> Published { get; set; }
        //public bool IsActive { get; set; }
        public StringBuilder Builder { get; set; }

        public string Name { get; set; }
        private List<TreeViewExampleModel> _treeview;
        public List<TreeViewExampleModel> TreeViewExamples
        {
            get
            {
                if (_treeview == null)
                {
                    _treeview = SessionProvider.Instance.DummyDataTreeview;

                }
                return _treeview;
            }
            set
            {
                _treeview = value;
            }


        }
        //private List<HttpPostedFileBase> _files;
        //public List<HttpPostedFileBase> Files
        //{
        //    get
        //    {
        //        if (_files == null)
        //        {
        //            _files = new List<HttpPostedFileBase>();

        //        }
        //        return _files;
        //    }
        //    set
        //    {
        //        _files = value;
        //    }
        //}
    }
}