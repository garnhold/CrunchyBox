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

    static public class TableLayoutPanelExtensions_Columns
    {
        static public void SetColumnsDefinitionString(this TableLayoutPanel item, string input)
        {
            item.ColumnStyles.Clear();

            input.SplitOn(",")
                .Convert(s => ColumnStyleExtensions.CreateFromDefinitionString(s))
                .Process(s => item.ColumnStyles.Add(s));

            item.ColumnCount = item.ColumnStyles.Count;
        }

        static public string GetColumnsDefinitionString(this TableLayoutPanel item)
        {
            return item.ColumnStyles.Bridge<ColumnStyle>().Convert(s => s.GetDefinitionString()).Join(", ");
        }
    }
}