using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomAxisExtensions_Conversion
    {
        static public InputAtom_Button GetAsButton(this InputAtom_Axis item, bool is_positive, float threshold = AxisSlider.Threshold)
        {
            return new InputAtom_Button_AxisLimit(item, is_positive, threshold);
        }

        static public InputAtom_Slider GetAsSlider(this InputAtom_Axis item, bool is_positive)
        {
            return new InputAtom_Slider_AxisHalf(item, is_positive);
        }
    }
}