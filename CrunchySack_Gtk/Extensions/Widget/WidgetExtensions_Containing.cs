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
    
    static public class WidgetExtensions_Containing
    {
        static public Widget GetImmediateContaining(this Widget item)
        {
            Window window;

            if (item.Convert<Window>(out window))
                return window.AttachedTo;

            return item.Parent;
        }

        static public IEnumerable<Widget> GetContaining(this Widget item)
        {
            return item.Traverse(i => i.GetImmediateContaining());
        }
    }
}