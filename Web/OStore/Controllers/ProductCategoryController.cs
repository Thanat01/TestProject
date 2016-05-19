using OStore.Models;
using OStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class ProductCategoryController : Controller
    {
       
        public ActionResult List()
        {

            Lazy<ProductCategoryViewModel> lazyModel = new Lazy<ProductCategoryViewModel>();
            ProductCategoryViewModel viewModel = lazyModel.Value;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult List(ProductCategoryViewModel model, string command)
        {
            try
            {
                //var ids = getTreeViewChecked(model.TreeViewExamples, 0, false);
                if(command=="Cancel")
                {
                    Lazy<ProductCategoryViewModel> lazyModel = new Lazy<ProductCategoryViewModel>();
                    ProductCategoryViewModel viewModel = lazyModel.Value;                   
                    return View(viewModel);
                }
            
                List<TreeViewExampleModel> checkedIds = new List<TreeViewExampleModel>();
                getTreeViewChecked2(model.TreeViewExamples, checkedIds);
                checkedIds.ForEach(c =>
                {
                    if(c.SubCategories==null)
                    {
                        c.SubCategories = new List<TreeViewExampleModel>();
                    }
                  
                    c.SubCategories.Add(new TreeViewExampleModel()
                    {
                        Checked = false,
                        Id = Convert.ToInt32( string.Format("{0}{1}", c.Id, c.SubCategories.Count()+1)),
                        Display = model.Name
                    });
                });


                return View("List", model);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        private List<int> getTreeViewChecked(List<TreeViewExampleModel> TreeViewExamples, int mainBranchIndex, bool haveSubs)
        {
            try
            {
                List<int> listOfCheckedIds = new List<int>();

                for (int i = 0; i < TreeViewExamples.Count; i++)
                {
                    if (TreeViewExamples[i].Checked)
                    {
                        listOfCheckedIds.Add(TreeViewExamples[i].Id);
                    }
                    if (TreeViewExamples[i].SubCategories != null)
                    {
                     
                        listOfCheckedIds.AddRange( getTreeViewChecked(TreeViewExamples[i].SubCategories, i, true));
                    }
                    //else
                    //{
                       


                    //    //if (haveSubs)
                    //    //{
                    //    //    if (TreeViewExamples[mainBranchIndex].SubCategories[i].Checked)
                    //    //    {
                    //    //        listOfCheckedIds.Add(TreeViewExamples[mainBranchIndex].SubCategories[i].Id);
                    //    //    }
                    //    //}
                    //    //else
                    //    //{
                    //        if (TreeViewExamples[i].Checked)
                    //        {
                    //            listOfCheckedIds.Add(TreeViewExamples[i].Id);
                    //        }
                    //   // }
                    //}
                }
                return listOfCheckedIds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void getTreeViewChecked2(List<TreeViewExampleModel> TreeViewExamples, List<TreeViewExampleModel> listOfCheckedIds)
        {
            try
            {
                TreeViewExamples.ForEach(category =>
                {
                    if (category.Checked)
                    {
                        listOfCheckedIds.Add(category);
                    }
                    else
                    {
                        if (category.SubCategories != null)
                            getTreeViewChecked2(category.SubCategories, listOfCheckedIds);
                    }
                });

              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet, ActionName("GetAllCategories")]
        public JsonResult GetAllCategories()
        {
            return Json(SessionProvider.Instance.ProductCategories, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create(int? parentId)
        {
            Session["CategoryId"] = string.Format("New_{0}", Guid.NewGuid().ToString());
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductCategoryViewModel category)
        {
            PMApi.Instance.UpdateProductCategory(new ModelApi.UpdateProductCategoryResquestModel() { Categories = new List<ProductCategoryViewModel> { category } });
           ImageProvider.Instance.ReCategoryPathName(Session["CategoryId"].ToString(), "");

            return View(SessionProvider.Instance.ProductCategories);
        }

        [HttpPost]
        public ActionResult SavePrimaryImageURL()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "1");
                    }
                }
            }
            catch
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
                return Json(new { Message = "Primary" });
            else
                return Json(new { Message = "Error in saving file" });
        }

        [HttpPost]
        public ActionResult SaveSecondaryImageURL()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    if (file != null && file.ContentLength > 0)
                    {
                        ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "2");
                    }
                }
            }
            catch
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
                return Json(new { Message = "Secondary" });
            else
                return Json(new { Message = "Error in saving file" });
        }
    }
}