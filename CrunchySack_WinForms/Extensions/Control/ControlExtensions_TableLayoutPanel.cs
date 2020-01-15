using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    static public class ControlExtensions_TableLayoutPanel
    {
        static public void SetColumn(this Control item, int column)
        {
            item.GetParent<TableLayoutPanel>().SetColumn(item, column);
        }

        static public void SetRow(this Control item, int row)
        {
            item.GetParent<TableLayoutPanel>().SetRow(item, row);
        }

        static public int GetColumn(this Control item)
        {
            return item.GetParent<TableLayoutPanel>().GetColumn(item);
        }

        static public int GetRow(this Control item)
        {
            return item.GetParent<TableLayoutPanel>().GetRow(item);
        }
    }
}