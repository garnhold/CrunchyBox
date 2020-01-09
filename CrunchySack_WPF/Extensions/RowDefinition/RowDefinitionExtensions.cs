using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack.WPF
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