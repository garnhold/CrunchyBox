using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    static public class GridExtensions_Rows
    {
        static public void SetRowsDefinitionString(this Grid item, string input)
        {
            item.RowDefinitions.Set(
                input.SplitOn(",").Convert(s => RowDefinitionExtensions.CreateFromDefinitionString(s))
            );
        }

        static public string GetRowsDefinitionString(this Grid item)
        {
            return item.RowDefinitions.Convert(c => c.GetDefinitionString()).ToString(", ");
        }
    }
}