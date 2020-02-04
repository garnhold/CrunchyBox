using System;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;

    public struct NotebookItem
    {
        private Widget tab;
        private Widget page;

        public NotebookItem(Widget t, Widget p)
        {
            tab = t;
            page = p;
        }

        public NotebookItem(string t, Widget p) : this(new Label(t), p) { }

        public Widget GetTab()
        {
            return tab;
        }

        public Widget GetPage()
        {
            return page;
        }
    }
}