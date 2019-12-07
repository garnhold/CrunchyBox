using System;
using System.IO;
using System.Text.RegularExpressions;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class GridLengthExtensions
    {
        static public GridLength Create(double input, string units)
        {
            return new GridLength(input, GridUnitTypeExtensions.Create(units));
        }

        [Conversion]
        static public GridLength Create(string input)
        {
            double value;
            string units;

            if (input.TryParseMeasurement(out value, out units))
                return Create(value, units);
            
            return new GridLength(value);
        }
    }
}