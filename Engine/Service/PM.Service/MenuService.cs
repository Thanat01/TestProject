using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class MenuService : IDisposable
    {

        private PM.Business.Menu _menu;

        public MenuService(int shopId, int userId)
        {
            _menu = new Business.Menu(shopId, userId);
        }

        public List<MenuModel> GetMenus()
        {
            try
            {
                return _menu.GetMenues();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_menu != null)
            {
                _menu = null;
            }
        }

        #endregion
    }
}
