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
    
    static public class MenuItemExtensions_Submenu
    {
        static public Menu FetchSubmenu(this MenuItem item)
        {
            if (item.Submenu == null)
                item.Submenu = new Menu();

            return item.Submenu as Menu;
        }

        static public void ClearSubmenu(this MenuItem item)
        {
            item.Submenu = null;
        }

        static public void RemoveSubmenuChildAt(this MenuItem item, int index)
        {
            item.FetchSubmenu().RemoveChildAt(index);
        }

        static public void AddSubmenuChild(this MenuItem item, Widget widget)
        {
            item.FetchSubmenu().AddChild(widget);
        }

        static public void InsertSubmenuChild(this MenuItem item, int index, Widget widget)
        {
            item.FetchSubmenu().InsertChild(index, widget);
        }
    }
}