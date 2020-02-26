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
    
    static public class NotebookExtensions_Tabs
    {
        static public IEnumerable<Widget> GetTabs(this Notebook item)
        {
            return item.GetPages().Convert(p => item.GetTabLabel(p));
        }
    }
}