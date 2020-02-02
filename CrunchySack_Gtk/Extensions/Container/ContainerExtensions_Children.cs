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
    
    static public class ContainerExtensions_Children
    {
        static public void ClearChildren(this Container item)
        {
            item.Children.ProcessCopy(w => item.Remove(w));
        }

        static public void RemoveChildAt(this Container item, int index)
        {
            item.Remove(item.GetChildAt(index));
        }

        static public void AddChild(this Container item, Widget widget)
        {
            item.Add(widget);
        }

        static public void InsertChild(this Container item, int index, Widget widget)
        {
            Widget[] new_children = item.Children.CopyInsert(index, widget);
            fasdadsffadsadsf
        }



        static public Widget GetChildAt(this Container item, int index)
        {
            return item.Children.Get(index);
        }
    }
}