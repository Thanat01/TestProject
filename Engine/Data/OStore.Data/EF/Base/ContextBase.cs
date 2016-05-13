using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OStore.Data.EF.Base
{
    public class ContextBase : DbContext
    {
        private int _UserId { get; set; }
        public ContextBase(int userId = 0) : base("name=OStoreDBEntities") { _UserId = userId; }

        public void Entry(object model, int userId, System.Data.Entity.EntityState state)
        {
            _UserId = userId;
            if (state == System.Data.Entity.EntityState.Added)
                StampCreateInfo(model);
            else
                StampUpdateInfo(model);

            base.Entry(model).State = state;
        }
        public void Entry(object model, System.Data.Entity.EntityState state)
        {
            if (state == System.Data.Entity.EntityState.Added)
                StampCreateInfo(model);
            else
                StampUpdateInfo(model);

            base.Entry(model).State = state;
        }

        public void DBEntry(object model, int userId, System.Data.Entity.EntityState state)
        {
            _UserId = userId;
            if (state == System.Data.Entity.EntityState.Added)
                StampCreateInfo(model);
            else
                StampUpdateInfo(model);

            base.Entry(model).State = state;
        }
        public void DBEntry(object model, System.Data.Entity.EntityState state)
        {
            if (state == System.Data.Entity.EntityState.Added)
                StampCreateInfo(model);
            else
                StampUpdateInfo(model);

            base.Entry(model).State = state;
        }

        private void StampCreateInfo(dynamic model)
        {
            try
            { model.CreateBy = _UserId; }
            catch { }

            try { model.CreateDate = DateTime.Now; }
            catch { }

        }

        private void StampUpdateInfo(dynamic model)
        {
            try { model.UpdateBy = _UserId; }
            catch { }

            try { model.UpdateDate = DateTime.Now; }
            catch { }
        }
    }
}
