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
            var menu = new List<Navbar>();
            menues.ForEach(m =>
            {
                bool hasChild = menues.Where(c => c.ParentId == m.Id).Count() > 0;
                menu.Add(new Navbar { Id = m.Id, nameOption = m.Name, controller = m.Controller, action = m.Action, imageClass = string.Format("fa {0} fa-fw", m.IconURL), status = true, isParent = hasChild, parentId = m.ParentId });
            });

            return menu.ToList();
        }
    }
}