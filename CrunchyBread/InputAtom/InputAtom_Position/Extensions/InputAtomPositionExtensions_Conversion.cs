using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomPositionExtensions_Conversion
    {
        static public InputAtom_Axis GetAsAxis(this InputAtom_Position item)
        {
            return new InputAtom_Axis_PositionDelta(item);
        }
    }
}