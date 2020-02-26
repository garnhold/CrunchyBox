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
    
    static public class NotebookExtensions_Pages
    {
        static public IEnumerable<Widget> GetPages(this Notebook item)
        {
            for (int i = 0; i < item.NPages; i++)
                yield return item.GetNthPage(i);
        }
    }
}