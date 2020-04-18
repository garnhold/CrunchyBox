using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomIntSliderExtensions_Conversion
    {
        static public InputAtom_Button GetAsButton(this InputAtom_IntSlider item)
        {
            return item.IfNotNull(i => new InputAtom_Button_IntSliderLimit(i));
        }

        static public InputAtom_Slider GetAsSlider(this InputAtom_IntSlider item)
        {
            return item.IfNotNull(i => new InputAtom_Slider_IntSlider(item));
        }
    }
}