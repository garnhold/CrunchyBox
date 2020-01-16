using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    static public class GridExtensions_Columns
    {
        static public void SetColumnsDefinitionString(this Grid item, string input)
        {
            item.ColumnDefinitions.Set(
                input.SplitOn(",").Convert(s => ColumnDefinitionExtensions.CreateFromDefinitionString(s))
            );
        }

        static public string GetColumnsDefinitionString(this Grid item)
        {
            return item.ColumnDefinitions.Convert(c => c.GetDefinitionString()).ToString(", ");
        }
    }
}