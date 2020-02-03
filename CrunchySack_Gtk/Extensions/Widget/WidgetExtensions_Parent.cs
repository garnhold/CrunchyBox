using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WidgetExtensions_Parent
    {
        static public IEnumerable<Widget> GetParents(this Widget item)
        {
            return item.Traverse(i => i.Parent);
        }

        static public T GetParent<T>(this Widget item)
        {
            return item.GetParents().FindFirstOfType<Widget, T>();
        }

        static public void SetChildPropertyOfParent<T>(this Widget item, string property_name, object value) where T : Container
        {
            item.GetParent<T>().ChildSetProperty(item, property_name, value.ConvertEX<GLib.Value>());
        }
        static public object GetChildPropertyOfParent<T>(this Widget item, string property_name) where T : Container
        {
            return item.GetParent<T>().ChildGetProperty(item, property_name);
        }
    }
}