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
    
    static public class AccelKeyExtensions
    {
        static public AccelKey Parse(string input, AccelFlags flags)
        {
            uint key;
            ModifierType modifier;

            Accelerator.Parse(input, out key, out modifier);
            return new AccelKey((Gdk.Key)key, modifier, flags);
        }
    }
}