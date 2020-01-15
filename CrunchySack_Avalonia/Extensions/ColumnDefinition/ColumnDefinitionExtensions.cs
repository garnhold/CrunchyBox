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
        static public ColumnDefinition Create(string input)
        {
            ColumnDefinition definition = new ColumnDefinition();

            definition.Width = GridLengthExtensions.Create(input);
            return definition;
        }
    }
}