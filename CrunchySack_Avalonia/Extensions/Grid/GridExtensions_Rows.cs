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
        static public void SetRowDefinitionString(this Grid item, string input)
        {
            item.RowDefinitions.Set(
                input.SplitOn(",").Convert(s => RowDefinitionExtensions.Create(s))
            );
        }

        static public string GetRowDefinitionString(this Grid item)
        {
            return item.RowDefinitions.Convert(c => c.Height).ToString(", ");
        }
    }
}