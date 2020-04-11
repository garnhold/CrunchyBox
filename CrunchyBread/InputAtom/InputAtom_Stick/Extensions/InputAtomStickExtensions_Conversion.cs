using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomStickExtensions_Conversion
    {
        static public InputAtom_Axis GetAsAxis(this InputAtom_Stick item, bool is_horizontal)
        {
            return item.IfNotNull(i => new InputAtom_Axis_StickHalf(i, is_horizontal));
        }
    }
}