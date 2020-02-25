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
    
    static public class WidgetExtensions_Accelerator
    {
        static public void AddBasicAccelerator(this Widget item, AcceleratorItem accelerator)
        {
            item.AddAccelerator(
                accelerator.GetSignal(),
                item.GetWindow().GetBasicAccelGroup(),
                accelerator.GetKey()
            );
        }
    }
}