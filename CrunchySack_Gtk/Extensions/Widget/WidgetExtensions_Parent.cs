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
    }
}