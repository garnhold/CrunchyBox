using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Measurement
    {
        static public bool TryParseMeasurement(this string item, out double value, out string units)
        {
            Match match = item.RegexMatch("^\\s*([0-9.-]+)?\\s*(\\S+)?\\s*$");

            Group value_group = match.Groups[1];
            Group label_group = match.Groups[2];

            value = 1.0;
            units = null;

            if (value_group.Success)
                value = value_group.Value.ParseDouble();

            if (label_group.Success)
            {
                units = label_group.Value;
                return true;
            }

            return false;
        }
    }
}