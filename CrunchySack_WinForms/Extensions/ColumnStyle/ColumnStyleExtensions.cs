using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Noodle;
    using Sack;

    [Conversion]
    static public class ColumnStyleExtensions
    {
        static public ColumnStyle CreateFromDefinitionString(float value, string units)
        {
            return new ColumnStyle(SizeTypeExtensions.CreateFromDefinitionString(units), value);
        }

        [Conversion]
        static public ColumnStyle CreateFromDefinitionString(string input)
        {
            double value;
            string units;

            input.TryParseMeasurement(out value, out units);
            return CreateFromDefinitionString((float)value, units);
        }

        [Conversion]
        static public string ToString(ColumnStyle item)
        {
            return item.GetDefinitionString();
        }
        static public string GetDefinitionString(this ColumnStyle item)
        {
            return item.SizeType.GetDefinitionString(item.Width);
        }
    }
}