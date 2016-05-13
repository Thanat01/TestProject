using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OStore.Libs.Extensions
{
    public class CheckBox
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Checked { get; set; }
    }

    public static class CheckBoxListExtension
    {
        public static List<CheckBox> ToCheckBoxList<T>(this IEnumerable<T> Items, Func<T, string> getText, Func<T, string> getValue)
        {
            List<CheckBox> items = new List<CheckBox>();
            foreach (var i in Items)
            {
                items.Add(new CheckBox()
                {
                    Checked = false,
                    Text = getText(i),
                    Value = getValue(i),
                });
            }

            return items
                .OrderBy(l => l.Text)
                .ToList();
        }
    }
}