using System;
using System.IO;
using System.Text.RegularExpressions;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class GridLengthExtensions
    {
        static public GridLength CreateFromDefinitionString(double value, string units)
        {
            return new GridLength(value, GridUnitTypeExtensions.CreateFromDefinitionString(units));
        }

        [Conversion]
        static public GridLength CreateFromDefinitionString(string input)
        {
            double value;
            string units;

            input.TryParseMeasurement(out value, out units);
            return CreateFromDefinitionString(value, units);
        }

        [Conversion]
        static public string ToString(GridLength item)
        {
            return item.GetDefinitionString();
        }
        static public string GetDefinitionString(this GridLength item)
        {
            return item.GridUnitType.GetDefinitionString(item.Value);
        }
    }
}