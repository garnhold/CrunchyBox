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
    static public class RowStyleExtensions
    {
        static public RowStyle CreateFromDefinitionString(float value, string units)
        {
            return new RowStyle(SizeTypeExtensions.CreateFromDefinitionString(units), value);
        }

        [Conversion]
        static public RowStyle CreateFromDefinitionString(string input)
        {
            double value;
            string units;

            input.TryParseMeasurement(out value, out units);
            return CreateFromDefinitionString((float)value, units);
        }

        [Conversion]
        static public string GetDefinitionString(this RowStyle item)
        {
            return item.SizeType.GetDefinitionString(item.Height);
        }
    }
}