using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomSliderExtensions_Conversion
    {
        static public InputAtom_Button GetAsButton(this InputAtom_Slider item, float threshold = AxisSlider.Threshold)
        {
            return item.IfNotNull(i => new InputAtom_Button_SliderLimit(i, threshold));
        }
    }
}