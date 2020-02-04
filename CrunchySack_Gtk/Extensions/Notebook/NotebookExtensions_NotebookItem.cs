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
    
    static public class NotebookExtensions_NotebookItem
    {
        static public void ClearNotebookItems(this Notebook item)
        {
            item.NPages.RepeatProcess(() => item.RemoveNotebookItemAt(0));
        }

        static public void RemoveNotebookItemAt(this Notebook item, int index)
        {
            item.RemovePage(index);
        }

        static public void AddNotebookItem(this Notebook item, NotebookItem to_add)
        {
            item.AppendPage(to_add.GetPage(), to_add.GetTab());
            to_add.GetTab().IfNotNull(t => t.ShowAll());
        }

        static public void InsertNotebookItem(this Notebook item, int index, NotebookItem to_insert)
        {
            item.InsertPage(to_insert.GetPage(), to_insert.GetTab(), index);
            to_insert.GetTab().IfNotNull(t => t.ShowAll());
        }
    }
}