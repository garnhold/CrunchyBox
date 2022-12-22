using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputDeviceMouseExtensions_Stick
    {
        static public InputAtom_Stick GetPositionStick(this InputDevice_Mouse item)
        {
            return new InputAtom_Stick_AxisPair(
                item.GetHorizontalPosition().GetAsAxis(),
                item.GetVerticalPosition().GetAsAxis()
            );
        }
    }
}