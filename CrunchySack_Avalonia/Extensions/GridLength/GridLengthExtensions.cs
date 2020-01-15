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
        static public GridLength Create(double value, string units)
        {
            return new GridLength(value, GridUnitTypeExtensions.Create(units));
        }

        [Conversion]
        static public GridLength Create(string input)
        {
            double value;
            string units;

            input.TryParseMeasurement(out value, out units);
            return Create(value, units);
        }
    }
}