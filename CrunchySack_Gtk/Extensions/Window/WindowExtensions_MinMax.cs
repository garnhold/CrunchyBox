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
    
    static public class WindowExtensions_MinMax
    {
        static public void Minimize(this Window item)
        {
            item.Iconify();
        }

        static public void Maximize(this Window item)
        {
            item.Maximize();
        }
    }
}