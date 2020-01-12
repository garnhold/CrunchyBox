using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    static public class TableLayoutPanelExtensions_Rows
    {
        static public void SetRowsDefinitionString(this TableLayoutPanel item, string input)
        {
            item.RowStyles.Clear();

            input.SplitOn(",")
                .Convert(s => RowStyleExtensions.CreateFromDefinitionString(s))
                .Process(s => item.RowStyles.Add(s));

            item.RowCount = item.RowStyles.Count;
        }

        static public string GetRowsDefinitionString(this TableLayoutPanel item)
        {
            return item.RowStyles.Bridge<RowStyle>().Convert(r => r.GetDefinitionString()).Join(", ");
        }
    }
}