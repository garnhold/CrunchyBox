using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
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