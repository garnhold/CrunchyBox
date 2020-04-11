using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_Axis_Native_Joystick : InputAtom_Axis_Native
    {
        private int device_index;
        private int axis_index;

        public InputAtom_Axis_Native_Joystick(int di, int ai)
        {
            device_index = di;
            axis_index = ai;
        }

        public override float GetRawValue()
        {
            return JoystickExtensions.GetState(device_index).GetAxis(axis_index);
        }
    }
}