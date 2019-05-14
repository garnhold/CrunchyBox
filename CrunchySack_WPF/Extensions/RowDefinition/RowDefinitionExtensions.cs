using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
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