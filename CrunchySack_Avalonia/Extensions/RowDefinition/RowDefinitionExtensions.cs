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
    static public class RowDefinitionExtensions
    {
        [Conversion]
        static public RowDefinition CreateFromDefinitionString(string input)
        {
            RowDefinition definition = new RowDefinition();

            definition.Height = GridLengthExtensions.CreateFromDefinitionString(input);
            return definition;
        }

        [Conversion]
        static public string GetDefinitionString(this RowDefinition item)
        {
            return item.Height.GetDefinitionString();
        }
    }
}