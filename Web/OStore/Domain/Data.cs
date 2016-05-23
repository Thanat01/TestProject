using OStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> NavbarItems(List<MenuItemModel> menues)
        {
            var mainMenues = new List<Navbar>();
            //menues.ForEach(m =>
            //{
            //    bool hasChild = menues.Where(c => c.ParentId == m.Id).Count() > 0;
            //    menu.Add(new Navbar { Id = m.Id, nameOption = m.Name, controller = m.Controller, action = m.Action, imageClass = string.Format("fa {0} fa-fw", m.IconURL), status = true, isParent = hasChild, parentId = m.ParentId });
            //});

            menues.Where(m => m.ParentId == 0).OrderBy(m => m.Seq).ToList().ForEach(f =>
            {
                Navbar menu = new Navbar() { Id = f.Id, nameOption = f.Name, controller = f.Controller, action = f.Action, imageClass = string.Format("fa {0} fa-fw", f.IconURL), status = true };
                GetChildMenus(menu, menues);
                mainMenues.Add(menu);
            });

            return mainMenues.ToList();
        }

        private void GetChildMenus( Navbar parentMenu,List<MenuItemModel> menues)
        {
            menues.Where(m => m.ParentId == parentMenu.Id).OrderBy(m => m.Seq).ToList().ForEach(c =>
            {
                Navbar menu = new Navbar() { Id = c.Id, nameOption = c.Name, controller = c.Controller, action = c.Action, imageClass = string.Format("fa {0} fa-fw", c.IconURL), status = true };
                GetChildMenus(menu, menues);
                parentMenu.ChildMenus.Add(menu);
            });
        }
    }
}