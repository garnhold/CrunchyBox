using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomButtonExtensions_Conversion
    {
        static public InputAtom_Axis GetAsAxis(this InputAtom_Button item, float value = 1.0f)
        {
            return item.IfNotNull(i => new InputAtom_Axis_Button(i, value));
        }

        static public InputAtom_Slider GetAsSlider(this InputAtom_Button item, float value = 1.0f)
        {
            return item.IfNotNull(i => new InputAtom_Slider_Button(i, value));
        }
    }
}