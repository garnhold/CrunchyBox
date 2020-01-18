using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;
using Gdk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WidgetExtensions_Property
    {
        static public void AddPropertyChangeProcess(this Widget item, EventType type, Process process)
        {
            item.PropertyNotifyEvent += delegate (object o, PropertyNotifyEventArgs args) {
                if (args.Event.Type == type)
                    process();
            };
        }
    }
}