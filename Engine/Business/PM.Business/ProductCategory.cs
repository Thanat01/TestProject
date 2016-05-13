using AutoMapper;
using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class ProductCategory : PM.Business.Base.ProductCategoryBase
    {

        public ProductCategory(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.ProductCategoryModel> GetAllProductCategory(int shopId)
        {
            try
            {
                List<OStore.Model.Base.ProductCategoryModel> result = new List<ProductCategoryModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    List<OStore.Data.EF.ProductCategory> categories = context.ProductCategories.Where(c => c.ShopId == shopId).ToList();
                    result = Mapper.Map(categories, result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddNewProductCategory(OStore.Model.Base.ProductCategoryModel model)
        {
            try
            {
                OStore.Data.EF.ProductCategory category = new OStore.Data.EF.ProductCategory();
                category = Mapper.Map(model, category);
                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities(CurrentUserId))
                {
                    context.DBEntry(category, System.Data.Entity.EntityState.Added);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateProductCategories(List<OStore.Model.Base.ProductCategoryModel> model)
        {
            try
            {
                List<OStore.Data.EF.ProductCategory>categories=new List<OStore.Data.EF.ProductCategory>();
                categories = Mapper.Map(model,categories );

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities(CurrentUserId))
                {
                    using (System.Data.Entity.DbContextTransaction tr = context.Database.BeginTransaction())
                    {
                        categories.Where(c => c.Id <= 0).ToList().ForEach(c =>
                        {
                            c.ParentId = CurrentShopId;
                            List<OStore.Data.EF.ProductCategory> childs = categories.Where(h => h.ParentId == c.Id).ToList();
                            context.DBEntry(c, System.Data.Entity.EntityState.Added);
                            context.SaveChanges();

                            childs.ForEach(d => d.ParentId = c.Id);
                        });

                        categories.Where(c => c.Id > 0).ToList().ForEach(c =>
                        {
                            c.ShopId = CurrentShopId;
                            context.DBEntry(c, System.Data.Entity.EntityState.Modified);
                        });

                        context.SaveChanges();
                        tr.Commit();  
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
