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