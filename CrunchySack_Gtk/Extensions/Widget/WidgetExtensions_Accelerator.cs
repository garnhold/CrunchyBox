using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;
using Gdk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Salt;
    using Noodle;
    using Sack;
    
    static public class WidgetExtensions_Accelerator
    {
        static public void AddBasicAccelerator(this Widget item, string signal, AccelKey key)
        {
            item.AddAccelerator(
                signal,
                item.GetBasicAccelGroup(),
                key
            );
        }
        static public void AddBasicAccelerator(this Widget item, AcceleratorItem accelerator)
        {
            item.AddBasicAccelerator(accelerator.GetSignal(), accelerator.GetKey());
        }
    }
}