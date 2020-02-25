using System;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;

    public struct AcceleratorItem
    {
        private string signal;
        private AccelKey key;

        public AcceleratorItem(string s, AccelKey k)
        {
            signal = s;
            key = k;
        }

        public AcceleratorItem(string s, Gdk.Key k, Gdk.ModifierType m, AccelFlags f) : this(s, new AccelKey(k, m, f)) { }
        public AcceleratorItem(string s, Gdk.Key k, Gdk.ModifierType m) : this(s, k, m, AccelFlags.Visible) { }

        public string GetSignal()
        {
            return signal;
        }

        public AccelKey GetKey()
        {
            return key;
        }
    }
}