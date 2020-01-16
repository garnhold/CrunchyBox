using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class ColumnDefinitionExtensions
    {
        [Conversion]
        static public ColumnDefinition CreateFromDefinitionString(string input)
        {
            ColumnDefinition definition = new ColumnDefinition();

            definition.Width = GridLengthExtensions.CreateFromDefinitionString(input);
            return definition;
        }

        [Conversion]
        static public string GetDefinitionString(this ColumnDefinition item)
        {
            return item.Width.GetDefinitionString();
        }
    }
}