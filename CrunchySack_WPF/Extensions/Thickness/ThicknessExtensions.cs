using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class ThicknessExtensions
    {
        static public Thickness Create(double value)
        {
            return new Thickness(value);
        }

        static public Thickness Create(double horizontal_value, double vertical_value)
        {
            return new Thickness(horizontal_value, vertical_value, horizontal_value, vertical_value);
        }

        static public Thickness Create(double left, double top, double right, double bottom)
        {
            return new Thickness(left, top, right, bottom);
        }

        [Conversion]
        static public Thickness Create(string input)
        {
            string number1;
            string number2;
            string number3;
            string number4;

            switch (input.SplitOn(",").PartOut(out number1, out number2, out number3, out number4))
            {
                case 1: return Create(number1.ParseDouble());
                case 2: return Create(number1.ParseDouble(), number2.ParseDouble());
                case 4: return Create(number1.ParseDouble(), number2.ParseDouble(), number3.ParseDouble(), number4.ParseDouble());
            }

            throw new ArgumentException("A comma seperated list of one, two, or four values is expected.", "input");
        }
    }
}