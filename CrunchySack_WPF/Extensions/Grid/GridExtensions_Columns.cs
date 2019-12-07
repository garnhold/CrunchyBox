using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    static public class GridExtensions_Columns
    {
        static public void SetColumnDefinitionString(this Grid item, string input)
        {
            item.ColumnDefinitions.Set(
                input.SplitOn(",").Convert(s => ColumnDefinitionExtensions.Create(s))
            );
        }

        static public string GetColumnDefinitionString(this Grid item)
        {
            return item.ColumnDefinitions.Convert(c => c.Width).ToString(", ");
        }
    }
}