using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputDeviceJoystickExtensions_Stick
    {
        static public InputAtom_Stick GetAxisPairStick(this InputDevice_Joystick item, int horizontal_axis_index, int vertical_axis_index)
        {
            return new InputAtom_Stick_AxisPair(
                item.GetAxis(horizontal_axis_index),
                item.GetAxis(vertical_axis_index)
            );
        }
    }
}