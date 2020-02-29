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
    
    static public class WidgetExtensions_AccelGroup
    {
        static public AccelGroup GetBasicAccelGroup(this Widget item)
        {
            return item.GetRootWindow().GetBasicAccelGroup();
        }
    }
}