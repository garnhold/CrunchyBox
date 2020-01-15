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
        static public RowDefinition Create(string input)
        {
            RowDefinition definition = new RowDefinition();

            definition.Height = GridLengthExtensions.Create(input);
            return definition;
        }
    }
}