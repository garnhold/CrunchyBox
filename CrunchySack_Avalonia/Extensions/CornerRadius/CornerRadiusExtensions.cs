﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class CornerRadiusExtensions
    {
        [Conversion] static public CornerRadius Create(double value) { return new CornerRadius(value); }

        [Conversion]static public CornerRadius Create(float value) { return Create((double)value); }
        [Conversion]static public CornerRadius Create(int value) { return Create((double)value); }

        static public CornerRadius Create(double horizontal_value, double vertical_value)
        {
            return new CornerRadius(horizontal_value, vertical_value, horizontal_value, vertical_value);
        }

        static public CornerRadius Create(double left, double top, double right, double bottom)
        {
            return new CornerRadius(left, top, right, bottom);
        }

        [Conversion]
        static public CornerRadius Create(string input)
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