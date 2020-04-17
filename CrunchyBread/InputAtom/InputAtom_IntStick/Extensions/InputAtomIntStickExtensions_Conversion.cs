using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomIntStickExtensions_Conversion
    {
        static public InputAtom_Stick GetAsStick(this InputAtom_IntStick item)
        {
            return item.IfNotNull(i => new InputAtom_Stick_IntStick(i));
        }
    }
}