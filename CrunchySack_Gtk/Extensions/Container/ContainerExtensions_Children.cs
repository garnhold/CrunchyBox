﻿using System;
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
        static public void SetChild(this Container item, Widget widget)
        {
            item.ClearChildren();
            item.AddChild(widget);
        }

        static public void SetChildren(this Container item, IEnumerable<Widget> widgets)
        {
            item.ClearChildren();
            item.AddChildren(widgets);
        }

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

        static public void AddChildren(this Container item, IEnumerable<Widget> widgets)
        {
            widgets.Process(w => item.AddChild(w));
        }

        static public void InsertChild(this Container item, int index, Widget widget)
        {
            item.Add(widget);
            item.Children.ShiftUpInsert(index, widget);
        }

        static public Widget GetChildAt(this Container item, int index)
        {
            return item.Children.Get(index);
        }
    }
}