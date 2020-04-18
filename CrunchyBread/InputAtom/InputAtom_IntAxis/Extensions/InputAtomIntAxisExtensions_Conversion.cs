using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomIntAxisExtensions_Conversion
    {
        static public InputAtom_Axis GetAsAxis(this InputAtom_IntAxis item)
        {
            return item.IfNotNull(i => new InputAtom_Axis_IntAxis(i));
        }

        static public InputAtom_Button GetAsButton(this InputAtom_IntAxis item, bool is_positive)
        {
            return item.IfNotNull(i => new InputAtom_Button_IntAxisLimit(item, is_positive));
        }

        static public InputAtom_IntSlider GetAsIntSlider(this InputAtom_IntAxis item, bool is_positive)
        {
            return item.IfNotNull(i => new InputAtom_IntSlider_IntAxisHalf(item, is_positive));
        }
    }
}