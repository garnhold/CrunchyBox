﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomAxisExtensions_Conversion
    {
        static public InputAtom_IntAxis GetAsIntAxis(this InputAtom_Axis item, float threshold = AxisSlider.Threshold)
        {
            return item.IfNotNull(i => new InputAtom_IntAxis_Axis(i, threshold));
        }

        static public InputAtom_Button GetAsButton(this InputAtom_Axis item, bool is_positive, float threshold = AxisSlider.Threshold)
        {
            return item.IfNotNull(i => new InputAtom_Button_AxisLimit(item, is_positive, threshold));
        }

        static public InputAtom_Slider GetAsSlider(this InputAtom_Axis item, bool is_positive)
        {
            return item.IfNotNull(i => new InputAtom_Slider_AxisHalf(item, is_positive));
        }
    }
}