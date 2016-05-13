using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OStore.Libs.Extensions
{
    public static class SelectListExtension
    {
        public static List<SelectListItem> ToSelectList<T>(this IEnumerable<T> Items, Func<T, string> getText, Func<T, string> getValue, string selectedValue, string noSelection, bool search = false)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            if (search)
            {
                items.Add(new SelectListItem { Selected = true, Value = "0", Text = string.Format("{0}", noSelection) });
            }

            foreach (var item in Items)
            {
                items.Add(new SelectListItem
                {
                    Text = getText(item),
                    Value = getValue(item),
                    Selected = selectedValue == getValue(item) ? true : false
                });
            }

            return items
                .OrderBy(l => l.Text)
                .ToList();
        }
    }
}