using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.Business
{
    public class Stock : IM.Business.Base.StockBase
    {
        public Stock(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.StockModel> GetStocks(int categoryId)
        {
            try
            {
                List<OStore.Model.StockModel> result = new List<OStore.Model.StockModel>();

                //using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                //{
                //    List<OStore.Data.EF.Product> products = (from pc in context.ProductCategories
                //                                             join cmp in context.ProductMapCategories on pc.Id equals cmp.ProductCategoryId
                //                                             join pd in context.Products on cmp.ProductId equals pd.Id
                //                                             where pc.ShopId == CurrentShopId && pd.ShopId == CurrentShopId && (categoryId == 0 || pc.Id == categoryId) && pc.IsActive && cmp.IsActive && pd.IsActive
                //                                             select pd).OrderBy(p => p.Seq).ToList();

                //    result = Mapper.Map(products, result);
                //}

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStock(OStore.Model.StockModel model)
        {
            try
            {
                //OStore.Data.EF.Product product = new OStore.Data.EF.Product();
                //product = Mapper.Map(model, product);

                //using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                //{
                //    if (product.Id <= 0)
                //        context.DBEntry(product, System.Data.Entity.EntityState.Added);
                //    else
                //        context.DBEntry(product, System.Data.Entity.EntityState.Modified);

                //    context.SaveChanges();
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
